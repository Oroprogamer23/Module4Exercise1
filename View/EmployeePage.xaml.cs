using Module0Exercise0.ViewModel;

namespace Module0Exercise0.View;

public partial class EmployeePage : ContentPage
{
	public EmployeePage()
	{
		InitializeComponent();
        BindingContext = new EmployeeViewModel();

    }
}