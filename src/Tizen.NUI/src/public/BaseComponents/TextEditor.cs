/*
 * Copyright(c) 2018 Samsung Electronics Co., Ltd.
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

extern alias TizenSystemSettings;
using TizenSystemSettings.Tizen.System;

using System;
using System.Runtime.InteropServices;
using System.Globalization;
using System.ComponentModel;
using Tizen.NUI.Binding;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// A control which provides a multi-line editable text editor.
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class TextEditor : View
    {
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.TEXT, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.TEXT).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Vector4), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.TEXT_COLOR, new Tizen.NUI.PropertyValue((Vector4)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.TEXT_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.FONT_FAMILY, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.FONT_FAMILY).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty FontStyleProperty = BindableProperty.Create(nameof(FontStyle), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.FONT_STYLE, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.FONT_STYLE).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PointSizeProperty = BindableProperty.Create(nameof(PointSize), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.POINT_SIZE, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.POINT_SIZE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty HorizontalAlignmentProperty = BindableProperty.Create(nameof(HorizontalAlignment), typeof(HorizontalAlignment), typeof(TextEditor), HorizontalAlignment.Begin, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.HORIZONTAL_ALIGNMENT, new Tizen.NUI.PropertyValue((int)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            if (Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.HORIZONTAL_ALIGNMENT).Get(out temp) == false)
            {
                NUILog.Error("HorizontalAlignment get error!");
            }

            switch (temp)
            {
                case "BEGIN":
                    return HorizontalAlignment.Begin;
                case "CENTER":
                    return HorizontalAlignment.Center;
                case "END":
                    return HorizontalAlignment.End;
                default:
                    return HorizontalAlignment.Begin;
            }
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ScrollThresholdProperty = BindableProperty.Create(nameof(ScrollThreshold), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_THRESHOLD, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_THRESHOLD).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ScrollSpeedProperty = BindableProperty.Create(nameof(ScrollSpeed), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_SPEED, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_SPEED).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PrimaryCursorColorProperty = BindableProperty.Create(nameof(PrimaryCursorColor), typeof(Vector4), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.PRIMARY_CURSOR_COLOR, new Tizen.NUI.PropertyValue((Vector4)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.PRIMARY_CURSOR_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SecondaryCursorColorProperty = BindableProperty.Create(nameof(SecondaryCursorColor), typeof(Vector4), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SECONDARY_CURSOR_COLOR, new Tizen.NUI.PropertyValue((Vector4)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SECONDARY_CURSOR_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EnableCursorBlinkProperty = BindableProperty.Create(nameof(EnableCursorBlink), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_CURSOR_BLINK, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_CURSOR_BLINK).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty CursorBlinkIntervalProperty = BindableProperty.Create(nameof(CursorBlinkInterval), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_BLINK_INTERVAL, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_BLINK_INTERVAL).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty CursorBlinkDurationProperty = BindableProperty.Create(nameof(CursorBlinkDuration), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_BLINK_DURATION, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_BLINK_DURATION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty CursorWidthProperty = BindableProperty.Create(nameof(CursorWidth), typeof(int), typeof(TextEditor), default(int), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_WIDTH, new Tizen.NUI.PropertyValue((int)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            int temp = 0;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.CURSOR_WIDTH).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty GrabHandleImageProperty = BindableProperty.Create(nameof(GrabHandleImage), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.GRAB_HANDLE_IMAGE, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.GRAB_HANDLE_IMAGE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty GrabHandlePressedImageProperty = BindableProperty.Create(nameof(GrabHandlePressedImage), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.GRAB_HANDLE_PRESSED_IMAGE, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.GRAB_HANDLE_PRESSED_IMAGE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandleImageLeftProperty = BindableProperty.Create(nameof(SelectionHandleImageLeft), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_IMAGE_LEFT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_IMAGE_LEFT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandleImageRightProperty = BindableProperty.Create(nameof(SelectionHandleImageRight), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_IMAGE_RIGHT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_IMAGE_RIGHT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandlePressedImageLeftProperty = BindableProperty.Create(nameof(SelectionHandlePressedImageLeft), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandlePressedImageRightProperty = BindableProperty.Create(nameof(SelectionHandlePressedImageRight), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandleMarkerImageLeftProperty = BindableProperty.Create(nameof(SelectionHandleMarkerImageLeft), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHandleMarkerImageRightProperty = BindableProperty.Create(nameof(SelectionHandleMarkerImageRight), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SelectionHighlightColorProperty = BindableProperty.Create(nameof(SelectionHighlightColor), typeof(Vector4), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HIGHLIGHT_COLOR, new Tizen.NUI.PropertyValue((Vector4)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SELECTION_HIGHLIGHT_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty DecorationBoundingBoxProperty = BindableProperty.Create(nameof(DecorationBoundingBox), typeof(Rectangle), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.DECORATION_BOUNDING_BOX, new Tizen.NUI.PropertyValue((Rectangle)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Rectangle temp = new Rectangle(0, 0, 0, 0);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.DECORATION_BOUNDING_BOX).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EnableMarkupProperty = BindableProperty.Create(nameof(EnableMarkup), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_MARKUP, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_MARKUP).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputColorProperty = BindableProperty.Create(nameof(InputColor), typeof(Vector4), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_COLOR, new Tizen.NUI.PropertyValue((Vector4)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputFontFamilyProperty = BindableProperty.Create(nameof(InputFontFamily), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_FONT_FAMILY, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_FONT_FAMILY).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputFontStyleProperty = BindableProperty.Create(nameof(InputFontStyle), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_FONT_STYLE, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_FONT_STYLE).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputPointSizeProperty = BindableProperty.Create(nameof(InputPointSize), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_POINT_SIZE, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_POINT_SIZE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty LineSpacingProperty = BindableProperty.Create(nameof(LineSpacing), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.LINE_SPACING, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.LINE_SPACING).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputLineSpacingProperty = BindableProperty.Create(nameof(InputLineSpacing), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_LINE_SPACING, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_LINE_SPACING).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty UnderlineProperty = BindableProperty.Create(nameof(Underline), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.UNDERLINE, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.UNDERLINE).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputUnderlineProperty = BindableProperty.Create(nameof(InputUnderline), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_UNDERLINE, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_UNDERLINE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ShadowProperty = BindableProperty.Create(nameof(Shadow), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SHADOW, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SHADOW).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputShadowProperty = BindableProperty.Create(nameof(InputShadow), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_SHADOW, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_SHADOW).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EmbossProperty = BindableProperty.Create(nameof(Emboss), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.EMBOSS, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.EMBOSS).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputEmbossProperty = BindableProperty.Create(nameof(InputEmboss), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_EMBOSS, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_EMBOSS).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty OutlineProperty = BindableProperty.Create(nameof(Outline), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.OUTLINE, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            PropertyMap temp = new PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.OUTLINE).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty InputOutlineProperty = BindableProperty.Create(nameof(InputOutline), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_OUTLINE, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.INPUT_OUTLINE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SmoothScrollProperty = BindableProperty.Create(nameof(SmoothScroll), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SMOOTH_SCROLL, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SMOOTH_SCROLL).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty SmoothScrollDurationProperty = BindableProperty.Create(nameof(SmoothScrollDuration), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SMOOTH_SCROLL_DURATION, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SMOOTH_SCROLL_DURATION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EnableScrollBarProperty = BindableProperty.Create(nameof(EnableScrollBar), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SCROLL_BAR, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SCROLL_BAR).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ScrollBarShowDurationProperty = BindableProperty.Create(nameof(ScrollBarShowDuration), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_BAR_SHOW_DURATION, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_BAR_SHOW_DURATION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ScrollBarFadeDurationProperty = BindableProperty.Create(nameof(ScrollBarFadeDuration), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_BAR_FADE_DURATION, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.SCROLL_BAR_FADE_DURATION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PixelSizeProperty = BindableProperty.Create(nameof(PixelSize), typeof(float), typeof(TextEditor), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.PIXEL_SIZE, new Tizen.NUI.PropertyValue((float)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            float temp = 0.0f;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.PIXEL_SIZE).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PlaceholderTextProperty = BindableProperty.Create(nameof(PlaceholderText), typeof(string), typeof(TextEditor), string.Empty, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER_TEXT, new Tizen.NUI.PropertyValue((string)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            string temp;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER_TEXT).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PlaceholderTextColorProperty = BindableProperty.Create(nameof(PlaceholderTextColor), typeof(Color), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER_TEXT_COLOR, new Tizen.NUI.PropertyValue((Color)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Color temp = new Color(0.0f, 0.0f, 0.0f, 0.0f);
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER_TEXT_COLOR).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EnableSelectionProperty = BindableProperty.Create(nameof(EnableSelection), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SELECTION, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SELECTION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(PropertyMap), typeof(TextEditor), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER, new Tizen.NUI.PropertyValue((PropertyMap)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.PLACEHOLDER).Get(temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty LineWrapModeProperty = BindableProperty.Create(nameof(LineWrapMode), typeof(LineWrapMode), typeof(TextEditor), LineWrapMode.Word, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.LINE_WRAP_MODE, new Tizen.NUI.PropertyValue((int)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            int temp;
            if (Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.LINE_WRAP_MODE).Get(out temp) == false)
            {
                NUILog.Error("LineWrapMode get error!");
            }
            return (LineWrapMode)temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty EnableShiftSelectionProperty = BindableProperty.Create(nameof(TextEditor.EnableShiftSelection), typeof(bool), typeof(TextEditor), true, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SHIFT_SELECTION, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            //textEditor.mShiftSelectionFlag(true);
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.ENABLE_SHIFT_SELECTION).Get(out temp);
            return temp;
        });
        /// This will be public opened in tizen_5.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty MatchSystemLanguageDirectionProperty = BindableProperty.Create(nameof(TextEditor.MatchSystemLanguageDirection), typeof(bool), typeof(TextEditor), false, propertyChanged: (bindable, oldValue, newValue) =>
        {
            var textEditor = (TextEditor)bindable;
            if (newValue != null)
            {
                Tizen.NUI.Object.SetProperty(textEditor.swigCPtr, TextEditor.Property.MATCH_SYSTEM_LANGUAGE_DIRECTION, new Tizen.NUI.PropertyValue((bool)newValue));
            }
        },
        defaultValueCreator: (bindable) =>
        {
            var textEditor = (TextEditor)bindable;
            bool temp = false;
            Tizen.NUI.Object.GetProperty(textEditor.swigCPtr, TextEditor.Property.MATCH_SYSTEM_LANGUAGE_DIRECTION).Get(out temp);
            return (bool)temp;
        });

        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        private string textEditorTextSid = null;
        private string textEditorPlaceHolderTextSid = null;
        private bool systemlangTextFlag = false;
        private InputMethodContext inputMethodContext = null;

        private EventHandler<TextChangedEventArgs> _textEditorTextChangedEventHandler;
        private TextChangedCallbackDelegate _textEditorTextChangedCallbackDelegate;

        private EventHandler<ScrollStateChangedEventArgs> _textEditorScrollStateChangedEventHandler;
        private ScrollStateChangedCallbackDelegate _textEditorScrollStateChangedCallbackDelegate;

        /// <summary>
        /// Creates the TextEditor control.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public TextEditor() : this(Interop.TextEditor.TextEditor_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Creates the TextEditor with setting the status of shown or hidden.
        /// </summary>
        /// <param name="shown">false : Not displayed (hidden), true : displayed (shown)</param>
        /// This will be public opened in next release of tizen after ACR done. Before ACR, it is used as HiddenAPI (InhouseAPI).
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TextEditor(bool shown) : this(Interop.TextEditor.TextEditor_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            SetVisible(shown);
        }

        internal TextEditor(TextEditor handle, bool shown = true) : this(Interop.TextEditor.new_TextEditor__SWIG_1(TextEditor.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            if (!shown)
            {
                SetVisible(false);
            }
        }

        internal TextEditor(global::System.IntPtr cPtr, bool cMemoryOwn, bool shown = true) : base(Interop.TextEditor.TextEditor_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);

            if (!shown)
            {
                SetVisible(false);
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TextChangedCallbackDelegate(IntPtr textEditor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void ScrollStateChangedCallbackDelegate(IntPtr textEditor, ScrollState state);

        /// <summary>
        /// An event for the TextChanged signal which can be used to subscribe or unsubscribe the event handler
        /// provided by the user. The TextChanged signal is emitted when the text changes.<br />
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<TextChangedEventArgs> TextChanged
        {
            add
            {
                if (_textEditorTextChangedEventHandler == null)
                {
                    _textEditorTextChangedCallbackDelegate = (OnTextChanged);
                    TextChangedSignal().Connect(_textEditorTextChangedCallbackDelegate);
                }
                _textEditorTextChangedEventHandler += value;
            }
            remove
            {
                _textEditorTextChangedEventHandler -= value;
                if (_textEditorTextChangedEventHandler == null && TextChangedSignal().Empty() == false)
                {
                    TextChangedSignal().Disconnect(_textEditorTextChangedCallbackDelegate);
                }
            }
        }

        /// <summary>
        /// Event for the ScrollStateChanged signal which can be used to subscribe or unsubscribe the event handler
        /// provided by the user. The ScrollStateChanged signal is emitted when the scroll state changes.<br />
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public event EventHandler<ScrollStateChangedEventArgs> ScrollStateChanged
        {
            add
            {
                if (_textEditorScrollStateChangedEventHandler == null)
                {
                    _textEditorScrollStateChangedCallbackDelegate = OnScrollStateChanged;
                    ScrollStateChangedSignal(this).Connect(_textEditorScrollStateChangedCallbackDelegate);
                }
                _textEditorScrollStateChangedEventHandler += value;
            }
            remove
            {
                _textEditorScrollStateChangedEventHandler -= value;
                if (_textEditorScrollStateChangedEventHandler == null && ScrollStateChangedSignal(this).Empty() == false)
                {
                    ScrollStateChangedSignal(this).Disconnect(_textEditorScrollStateChangedCallbackDelegate);
                }
            }
        }

        /// <summary>
        /// The TranslatableText property.<br />
        /// The text can set the SID value.<br />
        /// </summary>
        /// <exception cref='ArgumentNullException'>
        /// ResourceManager about multilingual is null.
        /// </exception>
        /// <since_tizen> 4 </since_tizen>
        public string TranslatableText
        {
            get
            {
                return textEditorTextSid;
            }
            set
            {
                if (NUIApplication.MultilingualResourceManager == null)
                {
                    throw new ArgumentNullException("ResourceManager about multilingual is null");
                }
                textEditorTextSid = value;
                Text = SetTranslatable(textEditorTextSid);
                NotifyPropertyChanged();
            }
        }
        /// <summary>
        /// The TranslatablePlaceholderText property.<br />
        /// The text can set the SID value.<br />
        /// </summary>
        /// <exception cref='ArgumentNullException'>
        /// ResourceManager about multilingual is null.
        /// </exception>
        /// <since_tizen> 4 </since_tizen>
        public string TranslatablePlaceholderText
        {
            get
            {
                return textEditorPlaceHolderTextSid;
            }
            set
            {
                if (NUIApplication.MultilingualResourceManager == null)
                {
                    throw new ArgumentNullException("ResourceManager about multilingual is null");
                }
                textEditorPlaceHolderTextSid = value;
                PlaceholderText = SetTranslatable(textEditorPlaceHolderTextSid);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Text property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValueAndForceSendChangeSignal(TextProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The TextColor property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4 TextColor
        {
            get
            {
                return (Vector4)GetValue(TextColorProperty);
            }
            set
            {
                SetValue(TextColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The FontFamily property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string FontFamily
        {
            get
            {
                return (string)GetValue(FontFamilyProperty);
            }
            set
            {
                SetValue(FontFamilyProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The FontStyle property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap FontStyle
        {
            get
            {
                return (PropertyMap)GetValue(FontStyleProperty);
            }
            set
            {
                SetValue(FontStyleProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The PointSize property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float PointSize
        {
            get
            {
                return (float)GetValue(PointSizeProperty);
            }
            set
            {
                SetValue(PointSizeProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The HorizontalAlignment property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public HorizontalAlignment HorizontalAlignment
        {
            get
            {
                return (HorizontalAlignment)GetValue(HorizontalAlignmentProperty);
            }
            set
            {
                SetValue(HorizontalAlignmentProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The ScrollThreshold property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float ScrollThreshold
        {
            get
            {
                return (float)GetValue(ScrollThresholdProperty);
            }
            set
            {
                SetValue(ScrollThresholdProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The ScrollSpeed property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float ScrollSpeed
        {
            get
            {
                return (float)GetValue(ScrollSpeedProperty);
            }
            set
            {
                SetValue(ScrollSpeedProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The PrimaryCursorColor property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4 PrimaryCursorColor
        {
            get
            {
                return (Vector4)GetValue(PrimaryCursorColorProperty);
            }
            set
            {
                SetValue(PrimaryCursorColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SecondaryCursorColor property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4 SecondaryCursorColor
        {
            get
            {
                return (Vector4)GetValue(SecondaryCursorColorProperty);
            }
            set
            {
                SetValue(SecondaryCursorColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The EnableCursorBlink property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public bool EnableCursorBlink
        {
            get
            {
                return (bool)GetValue(EnableCursorBlinkProperty);
            }
            set
            {
                SetValue(EnableCursorBlinkProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The CursorBlinkInterval property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float CursorBlinkInterval
        {
            get
            {
                return (float)GetValue(CursorBlinkIntervalProperty);
            }
            set
            {
                SetValue(CursorBlinkIntervalProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The CursorBlinkDuration property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float CursorBlinkDuration
        {
            get
            {
                return (float)GetValue(CursorBlinkDurationProperty);
            }
            set
            {
                SetValue(CursorBlinkDurationProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The CursorWidth property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public int CursorWidth
        {
            get
            {
                return (int)GetValue(CursorWidthProperty);
            }
            set
            {
                SetValue(CursorWidthProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The GrabHandleImage property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string GrabHandleImage
        {
            get
            {
                return (string)GetValue(GrabHandleImageProperty);
            }
            set
            {
                SetValue(GrabHandleImageProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The GrabHandlePressedImage property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string GrabHandlePressedImage
        {
            get
            {
                return (string)GetValue(GrabHandlePressedImageProperty);
            }
            set
            {
                SetValue(GrabHandlePressedImageProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandleImageLeft property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandleImageLeft
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandleImageLeftProperty);
            }
            set
            {
                SetValue(SelectionHandleImageLeftProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandleImageRight property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandleImageRight
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandleImageRightProperty);
            }
            set
            {
                SetValue(SelectionHandleImageRightProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandlePressedImageLeft property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandlePressedImageLeft
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandlePressedImageLeftProperty);
            }
            set
            {
                SetValue(SelectionHandlePressedImageLeftProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandlePressedImageRight property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandlePressedImageRight
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandlePressedImageRightProperty);
            }
            set
            {
                SetValue(SelectionHandlePressedImageRightProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandleMarkerImageLeft property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandleMarkerImageLeft
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandleMarkerImageLeftProperty);
            }
            set
            {
                SetValue(SelectionHandleMarkerImageLeftProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHandleMarkerImageRight property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap SelectionHandleMarkerImageRight
        {
            get
            {
                return (PropertyMap)GetValue(SelectionHandleMarkerImageRightProperty);
            }
            set
            {
                SetValue(SelectionHandleMarkerImageRightProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SelectionHighlightColor property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4 SelectionHighlightColor
        {
            get
            {
                return (Vector4)GetValue(SelectionHighlightColorProperty);
            }
            set
            {
                SetValue(SelectionHighlightColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The DecorationBoundingBox property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Rectangle DecorationBoundingBox
        {
            get
            {
                return (Rectangle)GetValue(DecorationBoundingBoxProperty);
            }
            set
            {
                SetValue(DecorationBoundingBoxProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The EnableMarkup property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public bool EnableMarkup
        {
            get
            {
                return (bool)GetValue(EnableMarkupProperty);
            }
            set
            {
                SetValue(EnableMarkupProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputColor property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Vector4 InputColor
        {
            get
            {
                return (Vector4)GetValue(InputColorProperty);
            }
            set
            {
                SetValue(InputColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputFontFamily property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string InputFontFamily
        {
            get
            {
                return (string)GetValue(InputFontFamilyProperty);
            }
            set
            {
                SetValue(InputFontFamilyProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputFontStyle property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap InputFontStyle
        {
            get
            {
                return (PropertyMap)GetValue(InputFontStyleProperty);
            }
            set
            {
                SetValue(InputFontStyleProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputPointSize property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float InputPointSize
        {
            get
            {
                return (float)GetValue(InputPointSizeProperty);
            }
            set
            {
                SetValue(InputPointSizeProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The LineSpacing property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float LineSpacing
        {
            get
            {
                return (float)GetValue(LineSpacingProperty);
            }
            set
            {
                SetValue(LineSpacingProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputLineSpacing property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float InputLineSpacing
        {
            get
            {
                return (float)GetValue(InputLineSpacingProperty);
            }
            set
            {
                SetValue(InputLineSpacingProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Underline property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap Underline
        {
            get
            {
                return (PropertyMap)GetValue(UnderlineProperty);
            }
            set
            {
                SetValue(UnderlineProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputUnderline property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string InputUnderline
        {
            get
            {
                return (string)GetValue(InputUnderlineProperty);
            }
            set
            {
                SetValue(InputUnderlineProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Shadow property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap Shadow
        {
            get
            {
                return (PropertyMap)GetValue(ShadowProperty);
            }
            set
            {
                SetValue(ShadowProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputShadow property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string InputShadow
        {
            get
            {
                return (string)GetValue(InputShadowProperty);
            }
            set
            {
                SetValue(InputShadowProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Emboss property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string Emboss
        {
            get
            {
                return (string)GetValue(EmbossProperty);
            }
            set
            {
                SetValue(EmbossProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputEmboss property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string InputEmboss
        {
            get
            {
                return (string)GetValue(InputEmbossProperty);
            }
            set
            {
                SetValue(InputEmbossProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Outline property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public PropertyMap Outline
        {
            get
            {
                return (PropertyMap)GetValue(OutlineProperty);
            }
            set
            {
                SetValue(OutlineProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The InputOutline property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string InputOutline
        {
            get
            {
                return (string)GetValue(InputOutlineProperty);
            }
            set
            {
                SetValue(InputOutlineProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SmoothScroll property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public bool SmoothScroll
        {
            get
            {
                return (bool)GetValue(SmoothScrollProperty);
            }
            set
            {
                SetValue(SmoothScrollProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The SmoothScrollDuration property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float SmoothScrollDuration
        {
            get
            {
                return (float)GetValue(SmoothScrollDurationProperty);
            }
            set
            {
                SetValue(SmoothScrollDurationProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The EnableScrollBar property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public bool EnableScrollBar
        {
            get
            {
                return (bool)GetValue(EnableScrollBarProperty);
            }
            set
            {
                SetValue(EnableScrollBarProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The ScrollBarShowDuration property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float ScrollBarShowDuration
        {
            get
            {
                return (float)GetValue(ScrollBarShowDurationProperty);
            }
            set
            {
                SetValue(ScrollBarShowDurationProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The ScrollBarFadeDuration property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float ScrollBarFadeDuration
        {
            get
            {
                return (float)GetValue(ScrollBarFadeDurationProperty);
            }
            set
            {
                SetValue(ScrollBarFadeDurationProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The PixelSize property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public float PixelSize
        {
            get
            {
                return (float)GetValue(PixelSizeProperty);
            }
            set
            {
                SetValue(PixelSizeProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The line count of the text.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public int LineCount
        {
            get
            {
                int temp = 0;
                GetProperty(TextEditor.Property.LINE_COUNT).Get(out temp);
                return temp;
            }
        }

        /// <summary>
        /// The text to display when the TextEditor is empty and inactive.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public string PlaceholderText
        {
            get
            {
                return (string)GetValue(PlaceholderTextProperty);
            }
            set
            {
                SetValue(PlaceholderTextProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Placeholder text color.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public Color PlaceholderTextColor
        {
            get
            {
                return (Color)GetValue(PlaceholderTextColorProperty);
            }
            set
            {
                SetValue(PlaceholderTextColorProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The EnableSelection property.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public bool EnableSelection
        {
            get
            {
                return (bool)GetValue(EnableSelectionProperty);
            }
            set
            {
                SetValue(EnableSelectionProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The Placeholder property.
        /// Gets or sets the placeholder: text, color, font family, font style, point size, and pixel size.
        /// </summary>
        /// <example>
        /// The following example demonstrates how to set the placeholder property.
        /// <code>
        /// PropertyMap propertyMap = new PropertyMap();
        /// propertyMap.Add("text", new PropertyValue("Setting Placeholder Text"));
        /// propertyMap.Add("textFocused", new PropertyValue("Setting Placeholder Text Focused"));
        /// propertyMap.Add("color", new PropertyValue(Color.Red));
        /// propertyMap.Add("fontFamily", new PropertyValue("Arial"));
        /// propertyMap.Add("pointSize", new PropertyValue(12.0f));
        ///
        /// PropertyMap fontStyleMap = new PropertyMap();
        /// fontStyleMap.Add("weight", new PropertyValue("bold"));
        /// fontStyleMap.Add("width", new PropertyValue("condensed"));
        /// fontStyleMap.Add("slant", new PropertyValue("italic"));
        /// propertyMap.Add("fontStyle", new PropertyValue(fontStyleMap));
        ///
        /// TextEditor editor = new TextEditor();
        /// editor.Placeholder = propertyMap;
        /// </code>
        /// </example>
        /// <since_tizen> 3 </since_tizen>
        public Tizen.NUI.PropertyMap Placeholder
        {
            get
            {
                return (PropertyMap)GetValue(PlaceholderProperty);
            }
            set
            {
                SetValue(PlaceholderProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The LineWrapMode property.<br />
        /// The line wrap mode when the text lines over the layout width.<br />
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public LineWrapMode LineWrapMode
        {
            get
            {
                return (LineWrapMode)GetValue(LineWrapModeProperty);
            }
            set
            {
                SetValue(LineWrapModeProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Enables Text selection using Shift key.
        /// </summary>
        /// <since_tizen> 5 </since_tizen>
        /// This will be released at Tizen.NET API Level 5, so currently this would be used as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool EnableShiftSelection
        {
            get
            {
                return (bool)GetValue(EnableShiftSelectionProperty);
            }
            set
            {
                SetValue(EnableShiftSelectionProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The text alignment to match the direction of the system language.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        public bool MatchSystemLanguageDirection
        {
            get
            {
                return (bool)GetValue(MatchSystemLanguageDirectionProperty);
            }
            set
            {
                SetValue(MatchSystemLanguageDirectionProperty, value);
                NotifyPropertyChanged();
            }
        }

        /// Only used by the IL of xaml, will never changed to not hidden.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool IsCreateByXaml
        {
            get
            {
                return base.IsCreateByXaml;
            }
            set
            {
                base.IsCreateByXaml = value;

                if (value == true)
                {
                    this.TextChanged += (obj, e) =>
                    {
                        this.Text = this.Text;
                    };
                }
            }
        }

        /// <summary>
        /// Get the InputMethodContext instance.
        /// </summary>
        /// <returns>The InputMethodContext instance.</returns>
        /// <since_tizen> 5 </since_tizen>
        public InputMethodContext GetInputMethodContext()
        {
            if (inputMethodContext == null)
            {
                /*Avoid raising InputMethodContext reference count.*/
                inputMethodContext = new InputMethodContext(Interop.TextEditor.TextEditor_GetInputMethodContext(swigCPtr), true);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            return inputMethodContext;
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextEditor obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        internal TextEditorSignal TextChangedSignal()
        {
            TextEditorSignal ret = new TextEditorSignal(Interop.TextEditor.TextEditor_TextChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ScrollStateChangedSignal ScrollStateChangedSignal(TextEditor textEditor)
        {
            ScrollStateChangedSignal ret = new ScrollStateChangedSignal(Interop.TextEditor.TextEditor_ScrollStateChangedSignal(TextEditor.getCPtr(textEditor)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t InputStyleChangedSignal()
        {
            SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextEditor_Dali__Toolkit__TextEditor__InputStyle__MaskF_t(Interop.TextEditor.TextEditor_InputStyleChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Dispose.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (this.HasBody() && _textEditorTextChangedCallbackDelegate != null)
            {
                TextChangedSignal().Disconnect(_textEditorTextChangedCallbackDelegate);
            }

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    // In order to speed up IME hide, temporarily add
                    GetInputMethodContext()?.DestroyContext();
                    Interop.TextEditor.delete_TextEditor(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }

        private void OnTextChanged(IntPtr textEditor)
        {
            TextChangedEventArgs e = new TextChangedEventArgs();

            // Populate all members of "e" (TextChangedEventArgs) with real data
            e.TextEditor = Registry.GetManagedBaseHandleFromNativePtr(textEditor) as TextEditor;

            if (_textEditorTextChangedEventHandler != null)
            {
                //here we send all data to user event handlers
                _textEditorTextChangedEventHandler(this, e);
            }

        }

        private void OnScrollStateChanged(IntPtr textEditor, ScrollState state)
        {
            ScrollStateChangedEventArgs e = new ScrollStateChangedEventArgs();

            if (textEditor != global::System.IntPtr.Zero)
            {
                // Populate all members of "e" (ScrollStateChangedEventArgs) with real data
                e.TextEditor = Registry.GetManagedBaseHandleFromNativePtr(textEditor) as TextEditor;
                e.ScrollState = state;
            }

            if (_textEditorScrollStateChangedEventHandler != null)
            {
                //here we send all data to user event handlers
                _textEditorScrollStateChangedEventHandler(this, e);
            }
        }

        private string SetTranslatable(string textEditorSid)
        {
            string translatableText = null;
            translatableText = NUIApplication.MultilingualResourceManager?.GetString(textEditorSid, new CultureInfo(SystemSettings.LocaleLanguage.Replace("_", "-")));
            if (translatableText != null)
            {
                if (systemlangTextFlag == false)
                {
                    SystemSettings.LocaleLanguageChanged += new WeakEventHandler<LocaleLanguageChangedEventArgs>(SystemSettings_LocaleLanguageChanged).Handler;
                    systemlangTextFlag = true;
                }
                return translatableText;
            }
            else
            {
                translatableText = "";
                return translatableText;
            }
        }

        private void SystemSettings_LocaleLanguageChanged(object sender, LocaleLanguageChangedEventArgs e)
        {
            if (textEditorTextSid != null)
            {
                Text = NUIApplication.MultilingualResourceManager?.GetString(textEditorTextSid, new CultureInfo(e.Value.Replace("_", "-")));
            }
            if (textEditorPlaceHolderTextSid != null)
            {
                PlaceholderText = NUIApplication.MultilingualResourceManager?.GetString(textEditorPlaceHolderTextSid, new CultureInfo(e.Value.Replace("_", "-")));
            }
        }

        /// <summary>
        /// Event arguments that passed via the TextChanged signal.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public class TextChangedEventArgs : EventArgs
        {
            private TextEditor _textEditor;

            /// <summary>
            /// TextEditor - is the texteditor control which has the text contents changed.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public TextEditor TextEditor
            {
                get
                {
                    return _textEditor;
                }
                set
                {
                    _textEditor = value;
                }
            }
        }

        /// <summary>
        /// Event arguments that passed via the ScrollStateChanged signal.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public class ScrollStateChangedEventArgs : EventArgs
        {
            private TextEditor _textEditor;
            private ScrollState _scrollState;

            /// <summary>
            /// TextEditor - is the texteditor control which has the scroll state changed.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public TextEditor TextEditor
            {
                get
                {
                    return _textEditor;
                }
                set
                {
                    _textEditor = value;
                }
            }

            /// <summary>
            /// ScrollState - is the texteditor control scroll state.
            /// </summary>
            /// <since_tizen> 3 </since_tizen>
            public ScrollState ScrollState
            {
                get
                {
                    return _scrollState;
                }
                set
                {
                    _scrollState = value;
                }
            }
        }

        internal new class Property
        {
            internal static readonly int RENDERING_BACKEND = Interop.TextEditor.TextEditor_Property_RENDERING_BACKEND_get();
            internal static readonly int TEXT = Interop.TextEditor.TextEditor_Property_TEXT_get();
            internal static readonly int TEXT_COLOR = Interop.TextEditor.TextEditor_Property_TEXT_COLOR_get();
            internal static readonly int FONT_FAMILY = Interop.TextEditor.TextEditor_Property_FONT_FAMILY_get();
            internal static readonly int FONT_STYLE = Interop.TextEditor.TextEditor_Property_FONT_STYLE_get();
            internal static readonly int POINT_SIZE = Interop.TextEditor.TextEditor_Property_POINT_SIZE_get();
            internal static readonly int HORIZONTAL_ALIGNMENT = Interop.TextEditor.TextEditor_Property_HORIZONTAL_ALIGNMENT_get();
            internal static readonly int SCROLL_THRESHOLD = Interop.TextEditor.TextEditor_Property_SCROLL_THRESHOLD_get();
            internal static readonly int SCROLL_SPEED = Interop.TextEditor.TextEditor_Property_SCROLL_SPEED_get();
            internal static readonly int PRIMARY_CURSOR_COLOR = Interop.TextEditor.TextEditor_Property_PRIMARY_CURSOR_COLOR_get();
            internal static readonly int SECONDARY_CURSOR_COLOR = Interop.TextEditor.TextEditor_Property_SECONDARY_CURSOR_COLOR_get();
            internal static readonly int ENABLE_CURSOR_BLINK = Interop.TextEditor.TextEditor_Property_ENABLE_CURSOR_BLINK_get();
            internal static readonly int CURSOR_BLINK_INTERVAL = Interop.TextEditor.TextEditor_Property_CURSOR_BLINK_INTERVAL_get();
            internal static readonly int CURSOR_BLINK_DURATION = Interop.TextEditor.TextEditor_Property_CURSOR_BLINK_DURATION_get();
            internal static readonly int CURSOR_WIDTH = Interop.TextEditor.TextEditor_Property_CURSOR_WIDTH_get();
            internal static readonly int GRAB_HANDLE_IMAGE = Interop.TextEditor.TextEditor_Property_GRAB_HANDLE_IMAGE_get();
            internal static readonly int GRAB_HANDLE_PRESSED_IMAGE = Interop.TextEditor.TextEditor_Property_GRAB_HANDLE_PRESSED_IMAGE_get();
            internal static readonly int SELECTION_HANDLE_IMAGE_LEFT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_IMAGE_RIGHT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HANDLE_PRESSED_IMAGE_LEFT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_PRESSED_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_PRESSED_IMAGE_RIGHT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_PRESSED_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HANDLE_MARKER_IMAGE_LEFT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_MARKER_IMAGE_LEFT_get();
            internal static readonly int SELECTION_HANDLE_MARKER_IMAGE_RIGHT = Interop.TextEditor.TextEditor_Property_SELECTION_HANDLE_MARKER_IMAGE_RIGHT_get();
            internal static readonly int SELECTION_HIGHLIGHT_COLOR = Interop.TextEditor.TextEditor_Property_SELECTION_HIGHLIGHT_COLOR_get();
            internal static readonly int DECORATION_BOUNDING_BOX = Interop.TextEditor.TextEditor_Property_DECORATION_BOUNDING_BOX_get();
            internal static readonly int ENABLE_MARKUP = Interop.TextEditor.TextEditor_Property_ENABLE_MARKUP_get();
            internal static readonly int INPUT_COLOR = Interop.TextEditor.TextEditor_Property_INPUT_COLOR_get();
            internal static readonly int INPUT_FONT_FAMILY = Interop.TextEditor.TextEditor_Property_INPUT_FONT_FAMILY_get();
            internal static readonly int INPUT_FONT_STYLE = Interop.TextEditor.TextEditor_Property_INPUT_FONT_STYLE_get();
            internal static readonly int INPUT_POINT_SIZE = Interop.TextEditor.TextEditor_Property_INPUT_POINT_SIZE_get();
            internal static readonly int LINE_SPACING = Interop.TextEditor.TextEditor_Property_LINE_SPACING_get();
            internal static readonly int INPUT_LINE_SPACING = Interop.TextEditor.TextEditor_Property_INPUT_LINE_SPACING_get();
            internal static readonly int UNDERLINE = Interop.TextEditor.TextEditor_Property_UNDERLINE_get();
            internal static readonly int INPUT_UNDERLINE = Interop.TextEditor.TextEditor_Property_INPUT_UNDERLINE_get();
            internal static readonly int SHADOW = Interop.TextEditor.TextEditor_Property_SHADOW_get();
            internal static readonly int INPUT_SHADOW = Interop.TextEditor.TextEditor_Property_INPUT_SHADOW_get();
            internal static readonly int EMBOSS = Interop.TextEditor.TextEditor_Property_EMBOSS_get();
            internal static readonly int INPUT_EMBOSS = Interop.TextEditor.TextEditor_Property_INPUT_EMBOSS_get();
            internal static readonly int OUTLINE = Interop.TextEditor.TextEditor_Property_OUTLINE_get();
            internal static readonly int INPUT_OUTLINE = Interop.TextEditor.TextEditor_Property_INPUT_OUTLINE_get();
            internal static readonly int SMOOTH_SCROLL = Interop.TextEditor.TextEditor_Property_SMOOTH_SCROLL_get();
            internal static readonly int SMOOTH_SCROLL_DURATION = Interop.TextEditor.TextEditor_Property_SMOOTH_SCROLL_DURATION_get();
            internal static readonly int ENABLE_SCROLL_BAR = Interop.TextEditor.TextEditor_Property_ENABLE_SCROLL_BAR_get();
            internal static readonly int SCROLL_BAR_SHOW_DURATION = Interop.TextEditor.TextEditor_Property_SCROLL_BAR_SHOW_DURATION_get();
            internal static readonly int SCROLL_BAR_FADE_DURATION = Interop.TextEditor.TextEditor_Property_SCROLL_BAR_FADE_DURATION_get();
            internal static readonly int PIXEL_SIZE = Interop.TextEditor.TextEditor_Property_PIXEL_SIZE_get();
            internal static readonly int LINE_COUNT = Interop.TextEditor.TextEditor_Property_LINE_COUNT_get();
            internal static readonly int ENABLE_SELECTION = Interop.TextEditor.TextEditor_Property_ENABLE_SELECTION_get();
            internal static readonly int PLACEHOLDER = Interop.TextEditor.TextEditor_Property_PLACEHOLDER_get();
            internal static readonly int LINE_WRAP_MODE = Interop.TextEditor.TextEditor_Property_LINE_WRAP_MODE_get();
            internal static readonly int PLACEHOLDER_TEXT = Interop.TextEditor.TextEditor_Property_PLACEHOLDER_TEXT_get();
            internal static readonly int PLACEHOLDER_TEXT_COLOR = Interop.TextEditor.TextEditor_Property_PLACEHOLDER_TEXT_COLOR_get();
            internal static readonly int ENABLE_SHIFT_SELECTION = Interop.TextEditor.TextEditor_Property_ENABLE_SHIFT_SELECTION_get();
            internal static readonly int MATCH_SYSTEM_LANGUAGE_DIRECTION = Interop.TextEditor.TextEditor_Property_MATCH_SYSTEM_LANGUAGE_DIRECTION_get();
        }

        internal class InputStyle
        {
            internal enum Mask
            {
                None = 0x0000,
                Color = 0x0001,
                FontFamily = 0x0002,
                PointSize = 0x0004,
                FontStyle = 0x0008,
                LineSpacing = 0x0010,
                Underline = 0x0020,
                Shadow = 0x0040,
                Emboss = 0x0080,
                Outline = 0x0100
            }
        }
    }
}
