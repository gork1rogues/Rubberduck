﻿using Rubberduck.Common;
using Rubberduck.Inspections.Abstract;
using Rubberduck.Parsing.Inspections.Abstract;
using Rubberduck.Parsing.Inspections.Resources;
using Rubberduck.Parsing.Symbols;

namespace Rubberduck.Inspections.Results
{
    public class SelfAssignedDeclarationInspectionResult : InspectionResultBase
    {
        public SelfAssignedDeclarationInspectionResult(IInspection inspection, Declaration target)
            : base(inspection, target) {}

        public override string Description
        {
            get
            {
                return string.Format(InspectionsUI.SelfAssignedDeclarationInspectionResultFormat, Target.IdentifierName).Capitalize();
            }
        }
    }
}
