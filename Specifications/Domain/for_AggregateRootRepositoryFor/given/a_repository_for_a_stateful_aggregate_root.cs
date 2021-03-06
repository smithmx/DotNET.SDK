﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
// using Dolittle.Artifacts;
// using Machine.Specifications;
// using Moq;

// namespace Dolittle.Domain.for_AggregateRootRepositoryFor.given
// {
//     public class a_repository_for_a_stateful_aggregate_root : a_command_context
//     {
//         protected static AggregateRootRepositoryFor<SimpleStatefulAggregateRoot> repository;
//         protected static Artifact artifact;

//         Establish context = () =>
//         {
//             repository = new AggregateRootRepositoryFor<SimpleStatefulAggregateRoot>(
//                 command_context_manager.Object,
//                 event_store.Object,
//                 event_source_versions.Object,
//                 artifact_type_map.Object,
//                 logger.Object);
//             command_context_manager.Setup(ccm => ccm.GetCurrent()).Returns(command_context_mock.Object);

//             artifact = Artifact.New();
//             artifact_type_map.Setup(a => a.GetArtifactFor(typeof(SimpleStatefulAggregateRoot))).Returns(artifact);
//         };
//     }
// }