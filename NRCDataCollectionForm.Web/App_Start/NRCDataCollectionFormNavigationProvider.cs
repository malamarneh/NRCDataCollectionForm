using Abp.Application.Navigation;
using Abp.Localization;

namespace NRCDataCollectionForm.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class NRCDataCollectionFormNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", NRCDataCollectionFormConsts.LocalizationSourceName),
                        url: "",
                        icon: "fa fa-home"
                        )
                );
        }
    }
}
