﻿using System.Linq;
using Bifrost.Read.Validation;
using Machine.Specifications;

namespace Bifrost.Specs.Rules.for_QueryValidationDescriptorFor
{
    public class when_describing_same_argument_twice : given.an_empty_query_validation_descriptor
    {
        static QueryArgumentValidationBuilder<SomeQuery> builder;

        Because of = () =>
        {
            descriptor.ForArgument(q => q.IntegerArgument);
            descriptor.ForArgument(q => q.IntegerArgument);
        };

        It should_only_have_one_builder = () => descriptor.Arguments.Count().ShouldEqual(1);
    }
}
