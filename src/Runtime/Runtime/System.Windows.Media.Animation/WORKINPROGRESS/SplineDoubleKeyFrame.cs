/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
*  KC adding support for this animation.
====================================================================================*/
using System;

#if MIGRATION
namespace System.Windows.Media.Animation
#else
namespace Windows.UI.Xaml.Media.Animation
#endif
{
    /// <summary>
    /// This class is used as part of a ByteKeyFrameCollection in
    /// conjunction with a KeyFrameByteAnimation to animate a
    /// Byte property value along a set of key frames.
    ///
    /// This ByteKeyFrame interpolates between the Byte Value of
    /// the previous key frame and its own Value to produce its output value.
    /// </summary>
    public sealed partial class SplineDoubleKeyFrame : DoubleKeyFrame
    {
        #region Constructors

        /// <summary>
        /// Creates a new SplineDoubleKeyFrame.
        /// </summary>
        public SplineDoubleKeyFrame()
            : base()
        {
        }

        /// <summary>
        /// Creates a new SplineDoubleKeyFrame.
        /// </summary>
        public SplineDoubleKeyFrame(Double value)
            : this()
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new SplineDoubleKeyFrame.
        /// </summary>
        public SplineDoubleKeyFrame(Double value, KeyTime keyTime)
            : this()
        {
            Value = value;
            KeyTime = keyTime;
        }

        /// <summary>
        /// Creates a new SplineDoubleKeyFrame.
        /// </summary>
        public SplineDoubleKeyFrame(Double value, KeyTime keyTime, KeySpline keySpline)
            : this()
        {
            if (keySpline == null)
            {
                throw new ArgumentNullException("keySpline");
            }

            Value = value;
            KeyTime = keyTime;
            KeySpline = keySpline;
        }

    #endregion

    #region Public Properties

        public static readonly DependencyProperty KeySplineProperty = DependencyProperty.Register("KeySpline", typeof(KeySpline),
                                                                                                             typeof(SplineDoubleKeyFrame),
                                                                                                             new PropertyMetadata(new KeySpline()));
        /// <summary>
        /// The KeySpline defines the way that progress will be altered for this key frame.
        /// </summary>
        public KeySpline KeySpline
        {
            get { return (KeySpline)GetValue(KeySplineProperty); }
            set { SetValue(KeySplineProperty, value); }
        }
    #endregion

        // todo: implement this. At the moment the animation is linear.
        internal override EasingFunctionBase INTERNAL_GetEasingFunction()
        {
            return base.INTERNAL_GetEasingFunction();
        }
    }
}