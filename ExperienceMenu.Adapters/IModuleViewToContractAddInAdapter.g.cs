//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExperienceMenu.Adapters
{
    
    [System.AddIn.Pipeline.AddInAdapterAttribute()]
    public class IModuleViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IModuleContract
    {
        private ExperienceMenu.Views.IModule _view;
        public IModuleViewToContractAddInAdapter(ExperienceMenu.Views.IModule view)
        {
            _view = view;
        }
        public Start9.Api.Contracts.IConfigurationContract Configuration
        {
            get
            {
                return ExperienceMenu.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.Configuration);
            }
            set
            {
                _view.Configuration = ExperienceMenu.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(value);
            }
        }
        public Start9.Api.Contracts.IMessageContractContract MessageContract
        {
            get
            {
                return ExperienceMenu.Adapters.IMessageContractAddInAdapter.ViewToContractAdapter(_view.MessageContract);
            }
        }
        public Start9.Api.Contracts.IReceiverContractContract ReceiverContract
        {
            get
            {
                return ExperienceMenu.Adapters.IReceiverContractAddInAdapter.ViewToContractAdapter(_view.ReceiverContract);
            }
        }
        public virtual void Initialize(Start9.Api.Contracts.IHostContract host)
        {
            _view.Initialize(ExperienceMenu.Adapters.IHostAddInAdapter.ContractToViewAdapter(host));
        }
        internal ExperienceMenu.Views.IModule GetSourceView()
        {
            return _view;
        }
    }
}

