using ReactiveUI;

namespace ctulhu.ViewModels;

public class MainViewModel : ViewModelBase
{
    /*<TextBox Watermark="Motive"></TextBox>
    <TextBox Watermark="Occupation"></TextBox>
    <TextBox Watermark="Expirience"></TextBox>*/
    private string _name;
    private string _motive;
    private string _occupation;
    private string _expirience;
    
    private int _mind;
    private int _control;
    private int _health;

    private int _selectedIndex;
    private bool _isMainSelected = true;
    private bool _isChatSelected;
    
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }
    
    public string Motive
    {
        get => _motive;
        set => this.RaiseAndSetIfChanged(ref _motive, value);
    }
    
    public string Occupation
    {
        get => _occupation;
        set => this.RaiseAndSetIfChanged(ref _occupation, value);
    }
    
    public string Expirience
    {
        get => _expirience;
        set => this.RaiseAndSetIfChanged(ref _expirience, value);
    }
    
    public int Mind
    {
        get => _mind;
        set => this.RaiseAndSetIfChanged(ref _mind, value);
    }
    
    public int Control
    {
        get => _control;
        set => this.RaiseAndSetIfChanged(ref _control, value);
    }
    
    public int Health
    {
        get => _health;
        set => this.RaiseAndSetIfChanged(ref _health, value);
    }
    
    public int SelectedIndex
    {
        get => _selectedIndex;
        set
        {
            if (value == 0)
            {
                IsMainSelected = true;
                IsChatSelected = false;
            }
            else
            {
                IsMainSelected = false;
                IsChatSelected = true;
                
            }
            this.RaiseAndSetIfChanged(ref _selectedIndex, value);
        }
    }

    public bool IsMainSelected
    {
        get => _isMainSelected;
        set => this.RaiseAndSetIfChanged(ref _isMainSelected, value);
    }
    
    public bool IsChatSelected
    {
        get => _isChatSelected;
        set => this.RaiseAndSetIfChanged(ref _isChatSelected, value);
    }
    
}