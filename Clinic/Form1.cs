using System.Data;

namespace Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private DataTable data = new DataTable(); // Creates the table
        private int queueCounter = 1;


        private void QueueButton_Click(object sender, EventArgs e)
        {
            // Checks age first if it's a number, puts it in a variable named 'age' if true
            if (int.TryParse(txtPatientAge.Text, out int age))
            {
                if (age > 130 || age < 0)
                {
                    MessageBox.Show("Please ensure Patient Age is within reasonable range.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please ensure Patient Age is a whole number.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (string.IsNullOrWhiteSpace(txtPatientName.Text) ||
              string.IsNullOrWhiteSpace(txtPatientAge.Text) ||
              cmbPatientType.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure Patient Name, Age, and Patient Type are completely filled.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;   // Catches missing inputs and tells the user to complete all fields
            }


            string queueNumberStr = $"Q{queueCounter:D3}"; // Formats int 1 to string "Q001"

            string selectedType = cmbPatientType.SelectedItem.ToString();
            string priorityText = "";

            switch (selectedType)
            {
                case "Emergency":
                    priorityText = "EMERGENCY";
                    break;
                case "Senior":
                    priorityText = "SENIOR PRIORITY";
                    break;
                case "Pregnant":
                    priorityText = "PRIORITY";
                    break;
                case "Regular":
                    priorityText = "REGULAR";
                    break;
                default:
                    priorityText = "REGULAR";
                    break;
            }

            data.Rows.Add(
               queueNumberStr,
               txtPatientName.Text,
               selectedType,
               priorityText
           ); // Fills the table with the necessary data
            queueCounter++;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            txtPatientAge.Clear();
            cmbPatientType.SelectedIndex = -1;
            cmbReasonForVisit.SelectedIndex = -1;
            txtPatientName.Focus();
            data.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Queue", typeof(string));
            data.Columns.Add("Patient", typeof(string));
            data.Columns.Add("Patient Type", typeof(string));
            data.Columns.Add("Priority", typeof(string));

            dataGridView1.DataSource = data;
            // Populates the table with the necessary columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; 
            // Resizes columns to prevent text cut off
        }

    }
}

