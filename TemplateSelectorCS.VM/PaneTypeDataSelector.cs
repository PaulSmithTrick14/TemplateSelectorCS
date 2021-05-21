using System.Windows;
using System.Windows.Controls;

namespace TemplateSelectorCS.VM
{
    class PaneTypeDataSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var element = container as FrameworkElement;
            if (element == null || item == null)
            {
                return null;
            }

            return element.FindResource(item.GetType().Name + "Template") as DataTemplate;
        }
    }
}
