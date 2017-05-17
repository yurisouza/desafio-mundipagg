﻿using DesafioMundiPagg.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMundiPagg.Infra.Data.Mappings
{
    public class EmprestimoSearchMapping : ElasticSearchMappingBase
    {
        public override string GetIndexForType(Type type)
        {
            return "emprestimos";
        }
    }
}
