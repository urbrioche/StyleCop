﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Shell {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Empty string is not a valid value for the argument '{0}'.
        /// </summary>
        internal static string Argument_EmptyString
        {
            get
            {
                return ResourceManager.GetString("Argument_EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To register the {0} file extension, you must prefix the extension with a &apos;.&apos;..
        /// </summary>
        internal static string Attributes_ExtensionNeedsDot {
            get {
                return ResourceManager.GetString("Attributes_ExtensionNeedsDot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The factoryType must be of one of those type: Type, Guid, string (representing a Guid)..
        /// </summary>
        internal static string Attributes_InvalidFactoryType {
            get {
                return ResourceManager.GetString("Attributes_InvalidFactoryType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project guid provided, but it is needed to register the extension for EditorFactoryNotify..
        /// </summary>
        internal static string Attributes_NoPrjForEditorFactoryNotify {
            get {
                return ResourceManager.GetString("Attributes_NoPrjForEditorFactoryNotify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Product Name was specified.  To register as an Installed Product, a Product Name is required..
        /// </summary>
        internal static string Attributes_ProductNameNotSpecified {
            get {
                return ResourceManager.GetString("Attributes_ProductNameNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown docking style: {0}..
        /// </summary>
        internal static string Attributes_UnknownDockingStyle {
            get {
                return ResourceManager.GetString("Attributes_UnknownDockingStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown relative position: {0}..
        /// </summary>
        internal static string Attributes_UnknownPosition {
            get {
                return ResourceManager.GetString("Attributes_UnknownPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve service {0}..
        /// </summary>
        internal static string Flavor_FailedToGetService {
            get {
                return ResourceManager.GetString("Flavor_FailedToGetService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting an array of size greater than zero..
        /// </summary>
        internal static string General_ArraySizeShouldBeAtLeast1 {
            get {
                return ResourceManager.GetString("General_ArraySizeShouldBeAtLeast1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected string that is not empty..
        /// </summary>
        internal static string General_ExpectedNonEmptyString {
            get {
                return ResourceManager.GetString("General_ExpectedNonEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected object of type {0}..
        /// </summary>
        internal static string General_InvalidType {
            get {
                return ResourceManager.GetString("General_InvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; must be installed for this feature to work.  Ensure that this service is available..
        /// </summary>
        internal static string General_MissingService {
            get {
                return ResourceManager.GetString("General_MissingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method called on a disposed object of type {0}..
        /// </summary>
        internal static string General_ObjectDisposed {
            get {
                return ResourceManager.GetString("General_ObjectDisposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported value: {0}..
        /// </summary>
        internal static string General_UnsupportedValue {
            get {
                return ResourceManager.GetString("General_UnsupportedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dialog page type {0} does not derive from DialogPage..
        /// </summary>
        internal static string Package_BadDialogPageType {
            get {
                return ResourceManager.GetString("Package_BadDialogPageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution option name {0} is invalid.  It cannot contain &apos;.&apos;, &apos;/&apos; or other special characters..
        /// </summary>
        internal static string Package_BadOptionName {
            get {
                return ResourceManager.GetString("Package_BadOptionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service {0} already exists in the service container..
        /// </summary>
        internal static string Package_DuplicateService {
            get {
                return ResourceManager.GetString("Package_DuplicateService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instance ID {0} is invalid..
        /// </summary>
        internal static string Package_InvalidInstanceID {
            get {
                return ResourceManager.GetString("Package_InvalidInstanceID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service instance must derive from or implement {0}..
        /// </summary>
        internal static string Package_InvalidServiceInstance {
            get {
                return ResourceManager.GetString("Package_InvalidServiceInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CreateToolWindow only creates Tool Windows derived from ToolWindowPane..
        /// </summary>
        internal static string Package_InvalidToolWindowClass {
            get {
                return ResourceManager.GetString("Package_InvalidToolWindowClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package requires that service &apos;{0}&apos; be installed.  Ensure that this service is available..
        /// </summary>
        internal static string Package_MissingService {
            get {
                return ResourceManager.GetString("Package_MissingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The solution option name {0} is already used by this package..
        /// </summary>
        internal static string Package_OptionNameUsed {
            get {
                return ResourceManager.GetString("Package_OptionNameUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The page type {0} does not offer an empty constructor..
        /// </summary>
        internal static string Package_PageCtorMissing {
            get {
                return ResourceManager.GetString("Package_PageCtorMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The page type {0} does not implement {1}..
        /// </summary>
        internal static string Package_PageMissingInterface {
            get {
                return ResourceManager.GetString("Package_PageMissingInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The page class {0} must derive from DialogPage..
        /// </summary>
        internal static string Package_PageNotDialogPage {
            get {
                return ResourceManager.GetString("Package_PageNotDialogPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A site has already been set on package {0}..
        /// </summary>
        internal static string Package_SiteAlreadySet {
            get {
                return ResourceManager.GetString("Package_SiteAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters {0} and {1} have incompatible types.
        /// </summary>
        internal static string Reg_ErrorIncompatibleParametersTypes {
            get {
                return ResourceManager.GetString("Reg_ErrorIncompatibleParametersTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters {0} and {1} have incompatible values.
        /// </summary>
        internal static string Reg_ErrorIncompatibleParametersValues {
            get {
                return ResourceManager.GetString("Reg_ErrorIncompatibleParametersValues", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Autoload package:         {0}.
        /// </summary>
        internal static string Reg_NotifyAutoLoad {
            get {
                return ResourceManager.GetString("Reg_NotifyAutoLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creatable Object: {0}.
        /// </summary>
        internal static string Reg_NotifyCreateObject {
            get {
                return ResourceManager.GetString("Reg_NotifyCreateObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Editor Extension: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyEditorExtension {
            get {
                return ResourceManager.GetString("Reg_NotifyEditorExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Editor Factory:   {0}.
        /// </summary>
        internal static string Reg_NotifyEditorFactory {
            get {
                return ResourceManager.GetString("Reg_NotifyEditorFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logical View:     {0}.
        /// </summary>
        internal static string Reg_NotifyEditorView {
            get {
                return ResourceManager.GetString("Reg_NotifyEditorView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extender:         {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyExtender {
            get {
                return ResourceManager.GetString("Reg_NotifyExtender", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed Product:   {0}, Version {1}.
        /// </summary>
        internal static string Reg_NotifyInstalledProduct {
            get {
                return ResourceManager.GetString("Reg_NotifyInstalledProduct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installed Product:   Using IVsInstalledProduct interface.
        /// </summary>
        internal static string Reg_NotifyInstalledProductInterface {
            get {
                return ResourceManager.GetString("Reg_NotifyInstalledProductInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key Binding: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyKeyBinding {
            get {
                return ResourceManager.GetString("Reg_NotifyKeyBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language Code Expansion: {0}.
        /// </summary>
        internal static string Reg_NotifyLanguageCodeExpansion {
            get {
                return ResourceManager.GetString("Reg_NotifyLanguageCodeExpansion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language Extension: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyLanguageExtension {
            get {
                return ResourceManager.GetString("Reg_NotifyLanguageExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LanguageOptionCategory: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyLanguageOptionCategory {
            get {
                return ResourceManager.GetString("Reg_NotifyLanguageOptionCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language Option Page: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyLanguageOptionPage {
            get {
                return ResourceManager.GetString("Reg_NotifyLanguageOptionPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language Service: {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyLanguageService {
            get {
                return ResourceManager.GetString("Reg_NotifyLanguageService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LoadKey:          {0} {1}
        ///Version {2}
        ///Edition Required: {3}.
        /// </summary>
        internal static string Reg_NotifyLoadKey {
            get {
                return ResourceManager.GetString("Reg_NotifyLoadKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Menu:             {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyMenuResource {
            get {
                return ResourceManager.GetString("Reg_NotifyMenuResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option Page:      {0}\{1}.
        /// </summary>
        internal static string Reg_NotifyOptionPage {
            get {
                return ResourceManager.GetString("Reg_NotifyOptionPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package:          {0} {1}.
        /// </summary>
        internal static string Reg_NotifyPackage {
            get {
                return ResourceManager.GetString("Reg_NotifyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project Factory:  {0}.
        /// </summary>
        internal static string Reg_NotifyProjectFactory {
            get {
                return ResourceManager.GetString("Reg_NotifyProjectFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project Items:    {0}.
        /// </summary>
        internal static string Reg_NotifyProjectItems {
            get {
                return ResourceManager.GetString("Reg_NotifyProjectItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service:          {0}.
        /// </summary>
        internal static string Reg_NotifyService {
            get {
                return ResourceManager.GetString("Reg_NotifyService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Statically Registered Toolbox Group: ID "{0}", Name "{1}".
        /// </summary>
        internal static string Reg_NotifyStaticToolboxGroup {
            get {
                return ResourceManager.GetString("Reg_NotifyStaticToolboxGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Statically Registered Toolbox Item: Group ID "{0}", Item ID "{1}", Item Name "{2}".
        /// </summary>
        internal static string Reg_NotifyStaticToolboxItem {
            get {
                return ResourceManager.GetString("Reg_NotifyStaticToolboxItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbox Items:    Version {0} (Formats: {1}).
        /// </summary>
        internal static string Reg_NotifyToolboxItem {
            get {
                return ResourceManager.GetString("Reg_NotifyToolboxItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbox Config:   {0}.
        /// </summary>
        internal static string Reg_NotifyToolboxItemConfiguration {
            get {
                return ResourceManager.GetString("Reg_NotifyToolboxItemConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to                    Filter: {0}.
        /// </summary>
        internal static string Reg_NotifyToolboxItemFilter {
            get {
                return ResourceManager.GetString("Reg_NotifyToolboxItemFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbox Page:     {0}.
        /// </summary>
        internal static string Reg_NotifyToolboxPage {
            get {
                return ResourceManager.GetString("Reg_NotifyToolboxPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ToolWindow:       {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyToolResource {
            get {
                return ResourceManager.GetString("Reg_NotifyToolResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tool Visibility:  {0}, {1}.
        /// </summary>
        internal static string Reg_NotifyToolVisibility {
            get {
                return ResourceManager.GetString("Reg_NotifyToolVisibility", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid toolbox item ID: {0}..
        /// </summary>
        internal static string Toolbox_InvalidItemId {
            get {
                return ResourceManager.GetString("Toolbox_InvalidItemId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbox item &quot;{0}&quot; not found on machine..
        /// </summary>
        internal static string Toolbox_ItemNotFound {
            get {
                return ResourceManager.GetString("Toolbox_ItemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported toolbox format: {0}..
        /// </summary>
        internal static string Toolbox_UnsupportedFormat {
            get {
                return ResourceManager.GetString("Toolbox_UnsupportedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package property of the tool window should only be set by the creator of the tool window..
        /// </summary>
        internal static string ToolWindow_PackageOnlySetByCreator {
            get {
                return ResourceManager.GetString("ToolWindow_PackageOnlySetByCreator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to toolClsid cannot be added after the Frame is created.
        ///Add the toolClsid in the ToolWindow constructor..
        /// </summary>
        internal static string ToolWindow_TooLateToAddTool {
            get {
                return ResourceManager.GetString("ToolWindow_TooLateToAddTool", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbar cannot be added after the Frame is created.
        ///Add the ToolBar in the ToolWindow constructor..
        /// </summary>
        internal static string ToolWindow_TooLateToAddToolbar {
            get {
                return ResourceManager.GetString("ToolWindow_TooLateToAddToolbar", resourceCulture);
            }
        }

        /// <summary>
        /// The default text of the wait dialog during a CommonMessagePump wait. 
        /// </summary>
        internal static string CommonMessagePumpDefaultWaitText
        {
            get {
                return ResourceManager.GetString("CommonMessagePumpDefaultWaitText"); 
            }
        }

        /// <summary>
        /// The default status bar text during a CommonMessagePump wait.
        /// </summary>
        internal static string CommonMessagePumpDefaultWaitStatusBarText
        {
            get {
                return ResourceManager.GetString("CommonMessagePumpDefaultWaitStatusBarText"); 
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoked on the wrong thread..
        /// </summary>
        internal static string Services_InvokedOnWrongThread
        {
            get {
                return ResourceManager.GetString("Services_InvokedOnWrongThread"); 
            }
        }
    }
}