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
    
    public class IHostViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IHostContract
    {
        private ExperienceMenu.Views.IHost _view;
        public IHostViewToContractAddInAdapter(ExperienceMenu.Views.IHost view)
        {
            _view = view;
        }
        public virtual void SendMessage(Start9.Api.Contracts.IMessageContract message)
        {
            _view.SendMessage(ExperienceMenu.Adapters.IMessageAddInAdapter.ContractToViewAdapter(message));
        }
        public virtual void SaveConfiguration(Start9.Api.Contracts.IModuleContract module)
        {
            _view.SaveConfiguration(ExperienceMenu.Adapters.IModuleAddInAdapter.ContractToViewAdapter(module));
        }
        public virtual System.AddIn.Contract.IListContract<Start9.Api.Contracts.IModuleContract> GetModules()
        {
            return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<ExperienceMenu.Views.IModule, Start9.Api.Contracts.IModuleContract>(_view.GetModules(), ExperienceMenu.Adapters.IModuleAddInAdapter.ViewToContractAdapter, ExperienceMenu.Adapters.IModuleAddInAdapter.ContractToViewAdapter);
        }
        public virtual Start9.Api.Contracts.IConfigurationContract GetGlobalConfiguration()
        {
            return ExperienceMenu.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(_view.GetGlobalConfiguration());
        }
        internal ExperienceMenu.Views.IHost GetSourceView()
        {
            return _view;
        }
    }
}

