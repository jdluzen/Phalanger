// ***
// Do not edit this file. It has been generated by the ClassDynamizer tool.
// ***
#pragma warning disable 0108
using PHP.Core.Reflection;
using System;
using System.Xml;
using System.Xml.XPath;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PHP.Core;
namespace PHP.Library.Xml
{
	[Serializable()]
	public partial class DOMXPath : PhpObject
	{
		protected DOMXPath(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public DOMXPath(ScriptContext context, bool newInstance) : base(context, newInstance)
		{
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public DOMXPath(ScriptContext context, DTypeDesc caller) : this(context, true)
		{
			this.InvokeConstructor(context, caller);
		}
		private static object __get_document(object instance)
		{
			return ((DOMXPath)instance).document;
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object __construct(ScriptContext __context, object document)
		{
			
			DOMDocument tmp1 = document as DOMDocument;
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(document, "DOMDocument", "__construct");
					return null;
				}
			__construct(tmp1);
			return null;
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object __construct(object instance, PhpStack stack)
		{
			stack.CalleeName = "__construct";
			
			object arg1 = stack.PeekValue(1);
			stack.RemoveFrame();
			return ((DOMXPath)instance).__construct(stack.Context, arg1);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object registerNamespace(ScriptContext __context, object prefix, object uri)
		{
			
			string tmp1 = PhpVariable.AsString(prefix);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(prefix, "string", "registerNamespace");
					return null;
				}
			
			string tmp2 = PhpVariable.AsString(uri);
			if (tmp2 == null)

				{
					PhpException.InvalidImplicitCast(uri, "string", "registerNamespace");
					return null;
				}
			return registerNamespace(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object registerNamespace(object instance, PhpStack stack)
		{
			stack.CalleeName = "registerNamespace";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValue(2);
			stack.RemoveFrame();
			return ((DOMXPath)instance).registerNamespace(stack.Context, arg1, arg2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object query(ScriptContext __context, object expr, 		[System.Runtime.InteropServices.OptionalAttribute()]
object context)
		{
			
			string tmp1 = PhpVariable.AsString(expr);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(expr, "string", "query");
					return null;
				}
			
			DOMNode tmp2 = null;
			if (context != Arg.Default)

				{
					tmp2 = context as DOMNode;
					if (tmp2 == null)

						{
							PhpException.InvalidImplicitCast(context, "DOMNode", "query");
							return null;
						}
				}
			return query(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object query(object instance, PhpStack stack)
		{
			stack.CalleeName = "query";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValueOptional(2);
			stack.RemoveFrame();
			return ((DOMXPath)instance).query(stack.Context, arg1, arg2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public object evaluate(ScriptContext __context, object expr, 		[System.Runtime.InteropServices.OptionalAttribute()]
object context)
		{
			
			string tmp1 = PhpVariable.AsString(expr);
			if (tmp1 == null)

				{
					PhpException.InvalidImplicitCast(expr, "string", "evaluate");
					return null;
				}
			
			DOMNode tmp2 = null;
			if (context != Arg.Default)

				{
					tmp2 = context as DOMNode;
					if (tmp2 == null)

						{
							PhpException.InvalidImplicitCast(context, "DOMNode", "evaluate");
							return null;
						}
				}
			return evaluate(tmp1, tmp2);
		}
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		public static object evaluate(object instance, PhpStack stack)
		{
			stack.CalleeName = "evaluate";
			
			object arg1 = stack.PeekValue(1);
			
			object arg2 = stack.PeekValueOptional(2);
			stack.RemoveFrame();
			return ((DOMXPath)instance).evaluate(stack.Context, arg1, arg2);
		}
		private static void __PopulateTypeDesc(PhpTypeDesc desc)
		{
			desc.AddProperty("document", PhpMemberAttributes.Public, new GetterDelegate(DOMXPath.__get_document), null);
			desc.AddMethod("__construct", PhpMemberAttributes.Public, new RoutineDelegate(DOMXPath.__construct));
			desc.AddMethod("registerNamespace", PhpMemberAttributes.Public, new RoutineDelegate(DOMXPath.registerNamespace));
			desc.AddMethod("query", PhpMemberAttributes.Public, new RoutineDelegate(DOMXPath.query));
			desc.AddMethod("evaluate", PhpMemberAttributes.Public, new RoutineDelegate(DOMXPath.evaluate));
		}
	}
}
