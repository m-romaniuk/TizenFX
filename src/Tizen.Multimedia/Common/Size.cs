/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Multimedia
{
    public struct Size
    {
        /// <summary>
        /// Initializes a new instance of the Size with the specified values.
        /// </summary>
        /// <param name="width">Width of the size.</param>
        /// <param name="height">Height of the size.</param>
        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Gets or sets the width of the Size.
        /// </summary>
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the height of the Size.
        /// </summary>
        public int Height
        {
            get;
            set;
        }

        public override string ToString() => $"Width={ Width }, Height={ Height }";

        public override int GetHashCode()
        {
            return new { Width, Height }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj is Size) == false)
            {
                return false;
            }

            Size rhs = (Size)obj;
            return Width == rhs.Width && Height == rhs.Height;
        }

        public static bool operator ==(Size lhs, Size rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Size lhs, Size rhs)
        {
            return !lhs.Equals(rhs);
        }
    }
}
