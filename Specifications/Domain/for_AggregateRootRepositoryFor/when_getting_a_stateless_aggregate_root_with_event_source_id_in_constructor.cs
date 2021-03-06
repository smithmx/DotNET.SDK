﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
// using System;
// using Dolittle.Domain;
// using Machine.Specifications;

// namespace Dolittle.Domain.for_AggregateRootRepositoryFor
// {
//     public class when_getting_a_stateless_aggregate_root_with_event_source_id_in_constructor : given.a_command_context
//     {
//         protected static AggregateRootRepositoryFor<AggregateRootWithEventSourceIdConstructor> aggregate_root_repository;
//         protected static AggregateRootWithEventSourceIdConstructor result;

//         Establish context = () => aggregate_root_repository = new AggregateRootRepositoryFor<AggregateRootWithEventSourceIdConstructor>(command_context_manager.Object, event_store.Object, event_source_versions.Object, artifact_type_map.Object, logger.Object);

//         Because of = () => result = aggregate_root_repository.Get(Guid.NewGuid());

//         It should_return_an_instance = () => result.ShouldNotBeNull();
//     }
// }