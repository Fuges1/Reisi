namespace Reisi
{

    public partial class Form1 : Form
    {
        private List<Flight> flights = new List<Flight>(); // ������ ������

        public Form1()
        {
            InitializeComponent();
            InitFlights(); // ������������� ������ ������
        }

        private void InitFlights()
        {
            // ���������� �������� ������
            flights.Add(new Flight("������", "STU123", "Boeing 767"));
            flights.Add(new Flight("�����-���������", "SU456", "Airbus A3450"));
            flights.Add(new Flight("������", "SU789", "Boeing 747"));
            flights.Add(new Flight("�����������", "SU7809", "������ Y7327"));
            flights.Add(new Flight("����������", "SU769", "�������� I747"));
            flights.Add(new Flight("�������", "IU489", "������ L747"));
            flights.Add(new Flight("������", "SOU7589", "���� B447"));
            flights.Add(new Flight("��������", "NU754", "����� G7477"));
            flights.Add(new Flight("������", "SU757", "��������� F740"));
            flights.Add(new Flight("������", "OU789", "�����-��������� C787"));
        }





        private void SearchFlights(string destination)
        {
            var result = flights.Where(f => f.Destination == destination)
                                .Select(f => $"{f.Number} - {f.Type}");
            if (result.Any())
            {
                txtDestination.Text = string.Join(Environment.NewLine, result);
                txtResult.Visible = false;
                txtDestination.Visible = true;
                btnOpenForm.Visible = false;
            }
            else
            {
                txtResult.Visible = false;
                txtDestination.Visible = true;
                btnOpenForm.Visible = false;
                txtDestination.Text = "����� �� �������";
            }
        }



        private void txtDestination_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            var form = new Form2(flights);
            form.ShowDialog(); // �������� ����� � ��������� ������
            if (form.DialogResult == DialogResult.OK)
            {
                string destination = form.Destination;
                SearchFlights(destination); // ����� ������ �� ������ ����������
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}