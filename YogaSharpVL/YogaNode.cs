using YogaSharp;

namespace YogaSharpVL
{
    public class YogaNode
    {
        private unsafe YGNode* _node;

        public YogaNode()
        {
            unsafe
            {
                _node = YGNode.New();
            }
        }
    }

    public static class NodesTest
    {
        // Seems to be never picked up if returns unsafe pointer
        public static unsafe YGNode* Create() => YGNode.New();
    }
}
