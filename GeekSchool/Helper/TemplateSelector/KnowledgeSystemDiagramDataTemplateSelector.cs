using Sago.Framework.Universal.Library.Common.BaseEntity;
using System;

namespace GeekSchool.Helper.TemplateSelector
{
    public class KnowledgeSystemDiagramDataTemplateSelector : DataTemplateSelectorBase<object>
    {
        public KnowledgeSystemDiagramDataTemplateSelector()
        {
            //TODO:判断是否是手机设备，这里还没有找到相关直接判断的方式，先采用判断是否存在物理后退按键来判断是否是手机或是其他设备
            this.PredicateForDataTemplateSelection = item => Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons");
        }

        protected override Predicate<object> PredicateForDataTemplateSelection { get; set; }
    }
}
