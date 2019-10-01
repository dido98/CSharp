using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            MessageBox.Show("this application is 2 in 1 app! Calc + even_odd solver");
            /*
            Задача 1: Напишете собствена функция AddNumbers(), която връща сумата от 2-те числа, тоест: double AddNumbers(double val1, double val2)
            Задача 2. Пренесете създадената функция AddNumbers() в отделен клас. За да създадете клас, то с десен бутон върху своя проект в “Solution Explorer”, избирате add a new class:
            Задача 3: Допълнете горната задача: добавете нови бутони и създайте съответните функции за пресмятане на разлика, частно и произведение на 2-те числа:
            Задача 4: Оптимизирайте кода във Form1.cs на задача 3, като разработите функция Calc(), която да се извиква от всички бутони на операции и да проверява какъв е текста (+,*,-,/) върху бутона (sender). В зависимост от него – да извиква коректната функция.
            Задача 5. Модифицирайте задача 3. За целта сложете във формата combobox и щракнете стрелката (arrow) в десния горен ъгъл и щракнете “Edit Items”: сега добавете операциите, които желаете:+ (“Add”),*(“Multiply”) и т.н. 
            Задача 6:  Създайте ново приложение от тип Windows Forms. Добавете един бутон (с надпис „even or odd”) , един етикет и едно текстово поле. Идеята е да се провери дали въведеното в текстовото поле число е четно или нечетно. Нека при стартиране на приложението на екрана да излиза съобщение, което да информира потребителите за целта на приложението, също при зареждане на формата – да се установява някакъв цвят на бутона (по избор): 
            Zadacha 7: try catch 
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Calc.AddNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Calc.SubNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Calc.MultiNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Calc.DivNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Add")
                textBox3.Text = Calc.AddNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            if (comboBox1.Text == "Sub")
                textBox3.Text = Calc.SubNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            if (comboBox1.Text == "Multi")
                textBox3.Text = Calc.MultiNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();

            if (comboBox1.Text == "Div")
                textBox3.Text = Calc.DivNumbers(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox4.Text) % 2 == 1)
                    label5.Text = "is Odd";
                else
                    label5.Text = "is Even";
            }
            catch(Exception)
            {
                label5.Text = "is not an Integer";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close this awesome application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
