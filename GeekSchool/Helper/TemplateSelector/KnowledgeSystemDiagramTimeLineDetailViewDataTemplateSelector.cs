using Sago.Framework.Universal.Library.Common.BaseEntity;
using System;
using Windows.UI.Xaml;

namespace GeekSchool.Helper.TemplateSelector
{
    public class KnowledgeSystemDiagramTimeLineDetailViewDataTemplateSelector : DataTemplateSelectorBase<object>
    {
        public KnowledgeSystemDiagramTimeLineDetailViewDataTemplateSelector()
        {
            var minWindowWidthOfWide = 0.0;
            double.TryParse(App.Current.Resources["MinWindowWidthOfWide"].ToString(), out minWindowWidthOfWide);

            var minWindowWidthOfNarrow = 0.0;
            double.TryParse(App.Current.Resources["MinWindowWidthOfNarrow"].ToString(), out minWindowWidthOfNarrow);

            var appWidth = Window.Current.Bounds.Width;

            //是否是宽屏
            this.PredicateForDataTemplateSelection = item => appWidth >= minWindowWidthOfWide;
        }

        protected override Predicate<object> PredicateForDataTemplateSelection { get; set; }
    }
}
