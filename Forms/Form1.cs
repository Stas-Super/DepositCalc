using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepositCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTerm.Items.Add("1 месяц");
            comboBoxTerm.Items.Add("3 месяца");
            comboBoxTerm.Items.Add("6 месяцев");
            comboBoxTerm.Items.Add("12 месяцев");

            comboBoxTerm.SelectedIndex = 3;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double sum;
            int months;

            #region Validation
            try
            {
                sum = Convert.ToDouble(
                    textBoxSum.Text.Replace('.',',') );
            }
            catch
            {
                MessageBox.Show("Введите корректную сумму");
                return;
            }
            switch (comboBoxTerm.SelectedIndex)
            {
                case 0: months = 1; break;
                case 1: months = 3; break;
                case 2: months = 6; break;
                case 3: months = 12; break;
                default:
                    MessageBox.Show("Выберите срок депозита");
                    return;
            }
            #endregion

            new Thread(Calc).Start(new Model.DepositData
            {
                Months = months,
                Sum = sum,
                IsBody = checkBoxBody.Checked,
                IsMonthly = checkBoxMonthly.Checked
            });
        }

        private void Calc(object? obj)
        {
            if (obj is Model.DepositData data)
            {
                Invoke((Action) ClearList);
                double percent = Math.Round((5 + 0.2 * data.Months), 2);
                String info = $"Общий процент - {percent}(годовой) / ";
                percent = Math.Round(percent / 12, 2);
                info += $"{percent}(месяц)";

                var act = new Action(() => listBoxRes.Items.Add(info));

                lock (listBoxRes)
                {
                    Invoke(act);
                }

                double totalPercents = 0;

                for (int i = 0; i < data.Months; i++)
                {
                    double monthSum = Math.Round(data.Sum * percent / 100, 2);
                    totalPercents += monthSum;

                    // Месяц: 1  Проценты: 11.31  Общая сумма: 1011.31
                    if (data.IsBody) data.Sum = Math.Round(data.Sum + monthSum, 2);
                    info = $"Месяц: {i+1} Проценты: {monthSum} Общая сумма: {data.Sum}"; 
                    lock (listBoxRes)
                    {
                        Invoke(act);
                    }
                }
                if (!data.IsMonthly)  // Вывод годовой суммы процентов, если выбран не-помесячный вариант
                {
                    totalPercents = Math.Round(totalPercents, 2);
                    info = $"По окончанию срока выплата: {totalPercents}";
                    lock (listBoxRes)
                    {
                        Invoke(act);
                    }
                }
                if (!data.IsBody)  // Вывод годовой суммы, если выбрано добавлять к телу 
                {
                    data.Sum = Math.Round(data.Sum + totalPercents, 2);
                    info = $"По окончанию срока сумма: {data.Sum}";
                    lock (listBoxRes)
                    {
                        Invoke(act);
                    }
                }
            }
            else throw new ArgumentException("Arg must be DepositData");
        }

        private void ClearList()
        {
            listBoxRes.Items.Clear();
        }
    }
}
