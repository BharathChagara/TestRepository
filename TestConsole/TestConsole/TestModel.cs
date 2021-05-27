using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class RuleEngineWorkFlowModel
    {
        /// <summary>
        /// Gets or sets the id of the workflow.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the workflows.
        /// </summary>
        public List<WorkflowRules> WorkFlows { get; set; }

    }
}
