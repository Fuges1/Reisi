namespace Reisi
{

    public partial class Form1 : Form
    {
        private List<Flight> flights = new List<Flight>(); // список рейсов

        public Form1()
        {
            InitializeComponent();
            InitFlights(); // инициализация списка рейсов
        }

        private void InitFlights()
        {
            // добавление тестовых данных
            flights.Add(new Flight("Москва", "STU123", "Boeing 767"));
            flights.Add(new Flight("Санкт-Петербург", "SU456", "Airbus A3450"));
            flights.Add(new Flight("Казань", "SU789", "Boeing 747"));
            flights.Add(new Flight("Владивасток", "SU7809", "Охотск Y7327"));
            flights.Add(new Flight("Калиниград", "SU769", "Радужный I747"));
            flights.Add(new Flight("Барнаул", "IU489", "Москва L747"));
            flights.Add(new Flight("Брянск", "SOU7589", "Тула B447"));
            flights.Add(new Flight("Чокурдах", "NU754", "Тверь G7477"));
            flights.Add(new Flight("Диксон", "SU757", "Махачкала F740"));
            flights.Add(new Flight("Диксон", "OU789", "Санкт-Петербург C787"));
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
                txtDestination.Text = "Рейсы не найдены";
            }
        }



        private void txtDestination_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            var form = new Form2(flights);
            form.ShowDialog(); // открытие формы в модальном режиме
            if (form.DialogResult == DialogResult.OK)
            {
                string destination = form.Destination;
                SearchFlights(destination); // поиск рейсов по пункту назначения
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