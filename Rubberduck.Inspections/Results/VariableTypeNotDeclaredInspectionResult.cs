using Rubberduck.Common;
using Rubberduck.Inspections.Abstract;
using Rubberduck.Parsing.Inspections.Abstract;
using Rubberduck.Parsing.Inspections.Resources;
using Rubberduck.Parsing.Symbols;

namespace Rubberduck.Inspections.Results
{
    public class VariableTypeNotDeclaredInspectionResult : InspectionResultBase
    {
        public VariableTypeNotDeclaredInspectionResult(IInspection inspection, Declaration target)
            : base(inspection, target) {}

        public override string Description
        {
            get
            {
                return string.Format(InspectionsUI.ImplicitVariantDeclarationInspectionResultFormat, 
                    Target.DeclarationType,
                    Target.IdentifierName).Capitalize();
            }
        }
    }
}
