using InvigulusData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invigulus_ExamMaintenance
{   /// <summary>
    /// Add/Update Exams sub-form.  
    /// Includes controls to add exams and to update exams.
    /// Authors:    Crystal (UI Design and button functionality)
    ///             Kevin Duong (Dynamic labels and validation)
    ///             Richard Galambos (Stylings)
    /// </summary>
    public partial class AddUpdateExamForm : Form
    {
        private bool isAdd;             // FLAG -> Used to identify if user is ADDING a new EXAM or UPDATING an existing one
        public Exam Exam { get; set; }  // Define  exam object
        
        /* Form constructor, needs to know if it's adding or updating and the exam selected */
        public AddUpdateExamForm(bool isAdd, Exam exam)
        {
            InitializeComponent();
            this.isAdd = isAdd;
            Exam = exam;

            /* Change the form based on whether the user is either adding or updating */
            if (isAdd)
            {   
                // For adding EXAMS
                this.Text = "Add Exam Form";                // Change Form Label
                ind_lbl_formtitle.Text = "Add Exam Page";   
                ctrl_btn_ok.Text = "Add";                   // Change Button text
                ctrl_tb_examname.Enabled = true;            // Exam name field ready for input
            }
            else
            {
                // For UPDATING Exams   
                this.Text = "Update Exam Form";             // Change Form Label
                ind_lbl_formtitle.Text = "Update Exam Page";
                ctrl_btn_ok.Text = "Update";                // Change Button text
                ctrl_tb_examname.Enabled = false;           // User cannot change the exam name

                ////Display old exam data in form
                ctrl_tb_examname.Text = Exam.ExamName;
                ctrl_tb_duration.Text = Exam.Duration.ToString();
                ctrl_tb_permattempt.Text = Exam.PermittedAttempts.ToString();
                ctrl_tb_url.Text = Exam.ExamURL.ToString();
            }
            //ind_tb_adminID.Text = exam.Administrator.ToString();
        }

        private void ctrl_btn_ok_Click(object sender, EventArgs e)
        {
            if (IsValidData()) //need to add validation
            {
                if ( isAdd )//user clicks *ADD* button| true is just a placeholder
                {
                    Exam newExam = new Exam();
                    newExam.Administrator = Exam.Administrator;
                    this.PutExamData(newExam);

                    try
                    {
                        Exam.ExamID = ExamDB.AddExam(newExam); //AddExam from ExamDb
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Add Successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else //user clicks *UPDATE* button
                {
                    Exam newExam = new Exam();
                    newExam.ExamID = Exam.ExamID;

                    this.PutExamData(newExam);
                    try
                    {
                        //Return error if update failed
                        if (!ExamDB.UpdateExam(Exam, newExam))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that exam.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                    }
                        else //Set the new exam as the form's exam and show success message
                        {
                            Exam = newExam;
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("Update Successful!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }

                    this.Close();
                }
            }
        }//end ok button click

        /* METHOD -> for assigning data from txt box to database */
        private void PutExamData(Exam exam) 
        {
            //id will not be changeable from this form

            //Set admin to the one selected in the main form
            exam.Administrator = Exam.Administrator;

            //Get inputs from the form
            exam.ExamName = ctrl_tb_examname.Text;
            exam.ExamURL = ctrl_tb_url.Text;

            if (ctrl_tb_duration.Text == "") //Consider empty string as null duration 
                exam.Duration = null;
            else
                exam.Duration = Convert.ToInt32(ctrl_tb_duration.Text);

            if (ctrl_tb_permattempt.Text == "") //Consider empty string as null attempts
                exam.PermittedAttempts = null;
            else
                exam.PermittedAttempts = Convert.ToInt32(ctrl_tb_permattempt.Text);
        }

        //Cancel button click event
        private void ctrl_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Check if the data entered in the fields is valid
        private bool IsValidData()
        {
            return
                (
                    Validator.IsPresent(ctrl_tb_examname, "Exam Name") &&
                    Validator.IsNullOrNonNegInt(ctrl_tb_duration, "Duration") &&
                    Validator.IsNullOrNonNegInt(ctrl_tb_permattempt, "Permitted Attempts") &&
                    Validator.IsPresent(ctrl_tb_url, "Exam URL")
                );
        }

    }//end namespace
}
