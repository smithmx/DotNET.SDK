﻿using System;
using doLittle.Concepts;
using doLittle.Specs.Concepts.given;
using Machine.Specifications;

namespace doLittle.Specs.Concepts.for_ConceptMap
{
    [Subject(typeof(ConceptMap))]
    public class when_getting_the_primitive_type_from_an_inherited_concept_based_on_a_long
    {
        static Type result;

        Because of = () => result = ConceptMap.GetConceptValueType(typeof(concepts.InheritingFromLongConcept));

        It should_get_a_long = () => result.ShouldEqual(typeof(long));
    }
}