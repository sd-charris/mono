//------------------------------------------------------------------------------
// <copyright file="WebPartEditorCancelVerb.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Web.UI.WebControls.WebParts {

    using System;

    internal sealed class WebPartEditorCancelVerb : WebPartActionVerb {

        // Properties must look at viewstate directly instead of the property in the base class,
        // so we can distinguish between an unset property and a property set to String.Empty.
        [
        WebSysDefaultValue(System.Web.SR.WebPartEditorCancelVerb_Description)
        ]
        public override string Description {
            get {
                object o = ViewState["Description"];
                return (o == null) ? System.Web.SR.GetString(System.Web.SR.WebPartEditorCancelVerb_Description) : (string)o;
            }
            set {
                ViewState["Description"] = value;
            }
        }

        [
        WebSysDefaultValue(System.Web.SR.WebPartEditorCancelVerb_Text)
        ]
        public override string Text {
            get {
                object o = ViewState["Text"];
                return (o == null) ? System.Web.SR.GetString(System.Web.SR.WebPartEditorCancelVerb_Text) : (string)o;
            }
            set {
                ViewState["Text"] = value;
            }
        }
    }
}
