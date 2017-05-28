﻿using Machine.Specifications;
using System;
using doLittle.Specs.Events.Fakes;

namespace doLittle.Specs.Events.for_EventSource.given
{
    public class a_stateless_event_source : all_dependencies
    {
        protected static StatelessAggregatedRoot event_source;
        protected static Guid event_source_id;

        Establish context = () =>
                {
                    event_source_id = Guid.NewGuid();
                    event_source = new StatelessAggregatedRoot(event_source_id);
                };
        
    }
}