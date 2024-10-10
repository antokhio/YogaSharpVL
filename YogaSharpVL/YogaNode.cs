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
}
