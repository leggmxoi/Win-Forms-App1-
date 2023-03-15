using rechner.models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double totalPrice = 0;
        double totalTaxes = 0;

        List<Produkt> table = new List<Produkt>();

        public Form1()
        {
            InitializeComponent();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        void rich1_TextChanged(object sender, EventArgs e)
        { }

        void Form1_Load(object sender, EventArgs e)
        { }

        void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(combobox0.SelectedItem.ToString());
            double price = double.Parse(combobox1.Text);
            string name = combobox2.Text;

            string printMessage = "";

            Produkt newProduct = new Produkt() { Amount = amount, Price = price, Name = name };

            table.Add(newProduct);

            printMessage = printMessage + coverLetter();

            printMessage = printMessage + "Produkt\t\t\t\tMenge\t\tUst.19%\t\tPreis\t\tGesamt";

            for (int i = 0; i < table.Count; i++)
            {
                printMessage = printMessage + @"
" + showPrice(table[i].Name, table[i].Amount, table[i].Price);
            }

            printMessage = printMessage + printShippingCosts();

            rich1.Text = printMessage + @"
" + "Gesamtsumme\t\t\t\t" + "Ust.:" + Math.Round(totalTaxes, 2) + " €\t\t" + totalPrice + "€";
        }

        void printRow(int rowNumber)
        {
            showPrice(table[rowNumber].Name, table[rowNumber].Amount, table[rowNumber].Price);
        }

        string showPrice(string productName, int amount, double price)
        {
            double total = amount * price;
            totalPrice = totalPrice + total;
            double ust = total * 0.19;

            return productName + "\t\t\t\t" + amount + "\t\t" + Math.Round(ust, 2) + "\t\t" + price  + "\t\t" + total;
        }
      
        string coverLetter()
        {
            string name = "Herr Flohr";
            string date = "13.03.2023";

           return "Hallo " + name + @"

Hiermit übersende ich ihnen die Rechnung für meine Leistungen am " + date + @".
Vielen Dank, dass Sie unsere Dienste genutzt haben.

Mit freundlichen Grüßen
Luis Wagner

";
        }
           

        string printShippingCosts()
        {
            if (totalPrice > 25)
            {
                return @"

" + "Versandkosten \t\t\t\t\t\t\t 0€";
            }
            else
            {
                const double shippingPrice = 5.95;

                string Text = @"

" + "Versandkosten \t\t\t\t\t\t\t" + shippingPrice + "€";

                totalTaxes = totalTaxes + shippingPrice * 0.19;
                totalPrice = totalPrice + shippingPrice;

                return Text;
            }
        }
    }
}