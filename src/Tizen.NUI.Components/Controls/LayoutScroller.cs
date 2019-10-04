/* Copyright (c) 2019 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI.Components
{
    /// <summary>
    /// [Draft] This class provides a View that can scroll a single View with a layout.
    /// </summary>
    public class LayoutScroller : CustomView
    {
        private Animation scrollAnimation;
        private float MaxScrollDistance;

        /// <summary>
        /// [Draft] Constructor
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public LayoutScroller() : base(typeof(VisualView).FullName, CustomViewBehaviour.ViewBehaviourDefault | CustomViewBehaviour.RequiresTouchEventsSupport)
        {
        }


        /// <summary>
        /// Scroll vertically by displacement pixels in screen coordinates.
        /// </summary>
        /// <param name="displacement">distance to scroll in pixels. Y increases as scroll position approaches the top.</param>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_5.5 after ACR done. Before ACR, need to be hidden as inhouse API.
        public float ScrollVerticallyBy(float displacement)
        {
            // if (mOrientation == HORIZONTAL)
            // {
            //     return 0;
            // }
            return ScrollBy(displacement);
        }

        internal void StopScroll()
        {
            if (scrollAnimation != null && scrollAnimation.State == Animation.States.Playing)
            {
                scrollAnimation.Stop(Animation.EndActions.StopFinal);
                scrollAnimation.Clear();
            }
        }

        // static constructor registers the control type (for user can add kinds of visuals to it)
        static LayoutScroller()
        {
            // ViewRegistry registers control type with DALi type registery
            // also uses introspection to find any properties that need to be registered with type registry
            CustomViewRegistry.Instance.Register(CreateInstance, typeof(LayoutScroller));
        }

        internal static CustomView CreateInstance()
        {
            return new LayoutScroller();
        }

        public void OffsetChildrenVertical(float displacement)
        {
            if (scrollAnimation == null)
            {
                scrollAnimation = new Animation();
            }
            else if (scrollAnimation.State == Animation.States.Playing)
            {
                scrollAnimation.Stop(Animation.EndActions.StopFinal);
                scrollAnimation.Clear();
            }
            scrollAnimation.Duration = 500;
            scrollAnimation.DefaultAlphaFunction = new AlphaFunction(AlphaFunction.BuiltinFunctions.EaseOutSquare);


            float targetPosition = this.PositionY + displacement;
            targetPosition = Math.Min(0,targetPosition);
            targetPosition = Math.Max(-MaxScrollDistance,targetPosition);
            Console.WriteLine("TargetPosition:{0}",targetPosition);

            scrollAnimation.AnimateTo(this, "PositionY", targetPosition);
            scrollAnimation.Play();
        }

        private float ScrollBy(float displacement)
        {
            if (GetChildCount() == 0 || displacement == 0)
            {
                return 0;
            }

            View parent = GetParent() as View;

            MaxScrollDistance = CurrentSize.Height -parent.CurrentSize.Height;

            //int layoutDirection = displacement < 0 ? LayoutState.LAYOUT_END : LayoutState.LAYOUT_START;
            float absDisplacement = Math.Abs(displacement);
            //UpdateLayoutState(layoutDirection, absDy, true);
            //float consumed = mLayoutState.ScrollingOffset;

            OffsetChildrenVertical(displacement);
            //mOrientationHelper.OffsetChildren(scrolled, immediate);


            return absDisplacement;
        }

    }

} // namespace
