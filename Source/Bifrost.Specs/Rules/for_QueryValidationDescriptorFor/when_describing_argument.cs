﻿using Bifrost.Read.Validation;
using Machine.Specifications;

namespace Bifrost.Specs.Rules.for_QueryValidationDescriptorFor
{
    public class when_describing_argument : given.an_empty_query_validation_descriptor
    {
        static QueryArgumentValidationBuilder<SomeQuery> builder;

        Because of = () => builder = descriptor.ForArgument(q => q.IntegerArgument);

        It should_return_a_builder = () => builder.ShouldNotBeNull();
        It should_have_the_builder_available = () => descriptor.Arguments.ShouldContainOnly(builder);
    }
}
