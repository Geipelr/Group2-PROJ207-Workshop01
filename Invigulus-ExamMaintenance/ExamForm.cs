using InvigulusData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Invigulus_ExamMaintenance
{
    /// <summary>
    /// <b>DESIGN:</b>INVIGULUS - Exam Proctoring 
    ///  ***Exam Editor
    /// <b>BY:</b>GROUP 2: Crystal Champion, Kevin Duong, Richard Galambos, Robert Geipal
    /// <b>DATE:</b>July 15, 2020
    /// <b>LAST MODIFIED:</b>July 29,2020
    /// <b>Version:</b> 1.0
    /// <b>NOTES:</b>
    /// Designed for - Rapid Application Development .NET
    /// Workshop 1 - Threaded Project
    /// </summary> 
    public partial class ExamForm : Form
    {

        public Exam exam = null;                            // Initialize Exam Object
        public List<ExamAdministrator> admins =
            new List<ExamAdministrator>();                  // Create List of EXAM ADMINISTRATOR Objects
        public List<ExamAdministrator> institutions =
            new List<ExamAdministrator>();                  // Create List of INSTITUTION Objects
        public List<Exam> exams = new List<Exam>();         // Create list of EXAN objects

        private string InstitutionName;                     // Stores selected Instituition (Filtering)
        private int adminID;                                // Stores selected AdminID (Filtering)

        public ExamForm()
        {
            InitializeComponent();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

            /* initialize institution combo box first */
            institutions = ExamAdministratorDB.GetInstitutions();
            // set combo box for institutions
            SetCbInstitutions();

            this.resetForm();
        }

        /* ADD a new exam */
        private void ctrl_btn_addExam_Click(object sender, EventArgs e)
        {
            AddUpdateExamForm addForm = new AddUpdateExamForm(true, new Exam { Administrator = adminID });

            /* Opens ADD/UPDATE form */
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshExams(addForm.Exam.ExamID);
                ctrl_btn_delete.Enabled = true;
                ctrl_btn_updateExam.Enabled = true; 
            }
        }

        /* UPDATE existing Exam */
        private void ctrl_btn_updateExam_Click(object sender, EventArgs e)
        {
            AddUpdateExamForm updateForm = new AddUpdateExamForm(false, exam);

            /* Opens ADD/UPDATE form */
            var result = updateForm.ShowDialog();
            if (result == DialogResult.OK)
                RefreshExams(updateForm.Exam.ExamID);
            else SetCbExams();
        }

        /* DELETE a new Exam (must not contain Registered Examinees */
        private void ctrl_btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Proceed with deleting {exam.ExamName} ?", "Delete Exam", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //delete record
                try
                {
                    ExamDB.DeleteExam(exam.ExamID);//removes from database
                    SetCbExams();
                    ctrl_btn_updateExam.Enabled = false;
                    ctrl_btn_delete.Enabled = false;
                    ctrl_tb_duration.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exam could not be deleted");
                    SetCbExams();
                }
            }
        }

        /* CLEAR and RESET Exam Form */
        private void ctrl_btn_clear_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        /* Choose the institution, only triggers on user selection */
        private void ctrl_cb_institution_SelectionChangeCommitted(object sender, EventArgs e)
        {
            uxReg.DataSource = null; //Clear registration table

            //Reset Exam Name combo box and clear duration textbox
            ctrl_tb_duration.Text = "";
            ctrl_cb_examName.Text = "";
            ctrl_cb_examName.DataSource = null;
            ctrl_cb_examName.Enabled = false;

            //Disable Exam related buttons
            ctrl_btn_delete.Enabled = false;
            ctrl_btn_updateExam.Enabled = false;
            ctrl_btn_addExam.Enabled = false;

            if (ctrl_cb_institution.SelectedIndex == 0) //if exam admin selected is our placeholder disable admin combobox
            {
                ctrl_cb_examName.DataSource = null;
                ctrl_cb_examAdmin.Enabled = false;
                ctrl_cb_examAdmin.DataSource = null;
            }
            else
            {
                // enable the next field
                ctrl_cb_examAdmin.Enabled = true;
                // institution name global in form for admin selection
                InstitutionName = ctrl_cb_institution.SelectedValue.ToString();
                // re-initialize admin list for new institution name
                SetCbAdmins();
            }
        }

        /* Choose the Admin, only triggers on user selection */
        private void ctrl_cb_examAdmin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Clear Exam combobox and set clear duration textbox
            ctrl_cb_examName.DataSource = null;
            ctrl_cb_examName.Text = "";
            ctrl_tb_duration.Text = "";

            uxReg.DataSource = null; //Clear registration table

            // Disable Delete/Update Exam
            ctrl_btn_delete.Enabled = false;
            ctrl_btn_updateExam.Enabled = false;

            if (ctrl_cb_examAdmin.SelectedIndex == 0) //if exam admin selected is our placeholder do not allow adding
            {
                ctrl_cb_examName.Enabled = false;
                ctrl_btn_addExam.Enabled = false;
            }
            else
            {
                // enable the next field and the option to add an exam
                ctrl_cb_examName.Enabled = true;
                ctrl_btn_addExam.Enabled = true;

                // filter exams by administrator
                adminID = Convert.ToInt32(ctrl_cb_examAdmin.SelectedValue);
                SetCbExams();
            }
        }

        /* Choose the Exam, only triggers on user selection */
        private void ctrl_cb_examName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ctrl_cb_examName.SelectedIndex == 0)//if exam name is our placeholder do not allow update/deletion
            {
                //Disable update/delete buttons 
                ctrl_btn_updateExam.Enabled = false;
                ctrl_btn_delete.Enabled = false;

                ctrl_tb_duration.Text = ""; //Clear duration textbox
                uxReg.DataSource = null; //Clear registration table
            }
            else
            {
                // SELECTS active EXAM
                exam = exams[ctrl_cb_examName.SelectedIndex];
                ctrl_tb_duration.Text = exam.Duration.ToString();
                this.enableAllOptions();
                // Displays Registrations
                uxReg.DataSource = ExamRegistrationDB.GetRegistrations(exam.ExamID);
            }
        }

        /* QUIT Button Handler - exit application */
        private void ctrl_btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Quit Application
        }


        /* LOCAL METHODS */

        /* METHOD -> sets the ExamForm back to default state */
        private void resetForm()
        {
            // RESET CONTROLS TO DEFAULT
            ctrl_cb_institution.SelectedIndex = 0;
            ctrl_cb_examAdmin.DataSource = null;            //empty out exam admin combo box
            ctrl_cb_examName.DataSource = null;             //empty out exam combo box
            uxReg.DataSource = null;
            ctrl_tb_duration.Text = "";
            ctrl_cb_examName.Text = "";

            // DISABLE CONTROLS
            ctrl_cb_examAdmin.Enabled = false;
            ctrl_cb_examName.Enabled = false;
            ctrl_tb_duration.Enabled = false;
            ctrl_btn_addExam.Enabled = false;
            ctrl_btn_updateExam.Enabled = false;
            ctrl_btn_delete.Enabled = false;
            uxReg.Enabled = false;
        }

        /* METHOD -> sets the ExamForm for USER interaction */
        private void enableAllOptions()
        {
            // ENABLE CONTROLS
            ctrl_btn_addExam.Enabled = true;
            ctrl_btn_updateExam.Enabled = true;
            ctrl_btn_delete.Enabled = true;
            uxReg.Enabled = true;
        }

        /* METHOD -> DataBinds the Institutions Combo Box */
        private void SetCbInstitutions()
        {
            institutions.Insert(0, new ExamAdministrator { InstitutionName = "Select Institution" });//instantiates placeholder object at index 0
            ctrl_cb_institution.DataSource = institutions;
            ctrl_cb_institution.DisplayMember = "InstitutionName";
            ctrl_cb_institution.ValueMember = "InstitutionName";

            // pick the first institution to restrict admins
            InstitutionName = institutions[0].InstitutionName;
        }

        /* METHOD -> DataBinds the Exam Administrators Combo Box */
        private void SetCbAdmins()
        {
            List<ExamAdministrator> admins_full = new List<ExamAdministrator>();
            admins_full = ExamAdministratorDB.GetAdministrators();
            // get all and restrict after
            admins = admins_full.Where(i => i.InstitutionName == InstitutionName).ToList();
            // initialize the admin list by restricting to institution selected before
            admins.Insert(0, new ExamAdministrator { FirstName = "Select Administrator", LastName = "", AdministratorID = -1 });//instantiates placeholder object at index 0

            ctrl_cb_examAdmin.DataSource = admins;
            ctrl_cb_examAdmin.DisplayMember = "FullName";
            ctrl_cb_examAdmin.ValueMember = "AdministratorID";
        }

        /* METHOD -> DataBinds the Exam Combo Box */
        private void SetCbExams()
        {
            exams = ExamDB.GetExamByAdmin(adminID);

            if (exams.Count > 0) //Admin has exams, display and enable the exam name combo box
            {
                exams.Insert(0, new Exam { ExamName = "Select Exam", ExamID = -1 });//instantiates placeholder object at index 0

                ctrl_cb_examName.DataSource = exams;
                ctrl_cb_examName.DisplayMember = "ExamName";
                ctrl_cb_examName.ValueMember = "ExamID";
                ctrl_cb_examName.Enabled = true;
                ctrl_tb_duration.Text = "";
            }
            else //Admin has no exams, disable Exam combo box
            {
                ctrl_cb_examName.DataSource = null;
                ctrl_cb_examName.Text = "No Exams Created";
                ctrl_cb_examName.Enabled = false;
                ctrl_btn_updateExam.Enabled = false;
                ctrl_btn_delete.Enabled = false;
                ctrl_tb_duration.Text = "";
            }
        }

        /* METHOS -> Refresh exam combo box and change index to the matching examID */
        private void RefreshExams(int examID)
        {
            SetCbExams();
            ctrl_cb_examName.SelectedValue = examID;
            exam = exams[ctrl_cb_examName.SelectedIndex];
            ctrl_tb_duration.Text = exam.Duration.ToString();
            uxReg.DataSource = ExamRegistrationDB.GetRegistrations(examID);
        }
    }
}
