using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Training
{
    /// <summary>
    /// Логика взаимодействия для TrainingDiary.xaml
    /// </summary>
    public partial class TrainingDiary : Window
    {
        public TrainingDiary()
        {
            InitializeComponent();
        }

        private void Back_Ground1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
