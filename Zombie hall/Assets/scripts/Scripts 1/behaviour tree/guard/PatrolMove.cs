using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts_1
{
    class PatrolMove : Behaviour
    {
        public override Status update()
        {
            // check for a target patrol node
            // if not present in blackboard, return fail

            // otherwise, move towards at movement speed
            return base.update();
        }
    }

    class PatrolFindNode : Behaviour
    {
        public override Status update()
        {
            // find list of nodes from blackboard
            // find the nearest node that has not been visited recently
            // store in blackboard as "target node"
            // return success
            return base.update();
        }
    }
}
