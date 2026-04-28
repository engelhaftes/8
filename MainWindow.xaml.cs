using System.Windows;

namespace LearnSmart
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Пока HomePage нет — показываем простую заглушку или StudentsWindow по умолчанию
            MainFrame.Navigate(new Views.StudentsWindow());   // временно открываем окно Студентов
        }

        private void NavHome_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Главная страница в разработке");
            MainFrame.Navigate(new Views.StudentsWindow()); // пока заглушка
        }

        private void NavStudents_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.StudentsWindow());
        }

        private void NavGroups_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Views.GroupsWindow());
        }

        private void BtnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция генерации PDF-отчёта будет добавлена позже.",
                            "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnExportExcel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Экспорт в Excel будет реализован на следующем этапе.",
                            "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnClearAll_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить все данные?",
                                "Подтверждение",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Данные очищены (пока без реальной логики).", "Готово");
            }
        }
    }
}