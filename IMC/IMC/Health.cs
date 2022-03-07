using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    class Health
    {
        private float weight;
        private float height;

        public Health(float height, float weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public float GetWeight()
        {
            return weight;
        }

        public void SetWeight(float weight)
        {
            this.weight = weight;
        }

        public float GetHeight()
        {
            return height;
        }

        public void SetHeight(float height)
        {
            this.height = height;
        }
    }
}
