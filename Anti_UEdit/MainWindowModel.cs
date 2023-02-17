using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using Flattiverse.Connector;
using Flattiverse.Connector.Units;

namespace Anti_UEdit;

public class MainWindowModel : ViewModelBase
{

    public string UniverseGroupUrl { get; set; }
    
    public ObservableCollection<Unit> Units { get; init; }
    public ObservableCollection<Unit> SelectedUnits { get; init; }


    private UniverseGroup? _universeGroup;

    public MainWindowModel()
    {
        
    }



}