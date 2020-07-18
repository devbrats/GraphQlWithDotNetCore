﻿using GraphQL.Types;

namespace GraphQlWithNetCore.GraphQl.Types
{
    public class TestResultInputType : InputObjectGraphType
    {
        public TestResultInputType()
        {
            Name = "testResultInput";
            Field<NonNullGraphType<StringGraphType>>("resultId");
            Field<IntGraphType>("testId");
            Field<VerdictEnumType>("verdict");
        }
    }
}
