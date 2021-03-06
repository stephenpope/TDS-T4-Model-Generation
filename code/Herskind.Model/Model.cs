﻿using System;
using Sitecore.Data.Items;
using Herskind.Model.Helper;
using Herskind.Model.Helper.FieldTypes;
 

#region Sample Item (Sample)
namespace Herskind.Model.Sample
{
	public partial interface ISampleItem : IItemWrapper 
	{		
		ITextFieldWrapper Text { get; }		
		ITextFieldWrapper Title { get; }		
			
	}

	[TemplateMapping("{76036F5E-CBCE-46D1-AF0A-4143F9B557AA}")]
	public class SampleItem : BaseItemWrapper, ISampleItem
	{
		private Item _innerItem = null;
		public SampleItem(Item item) : base(item)
		{
			_innerItem = item;
		}

		public ITextFieldWrapper Text
		{
			get 
			{
				return (ITextFieldWrapper)GetField("a60acd61-a6db-4182-8329-c957982cec74"); 
			} 
		} 	

		public ITextFieldWrapper Title
		{
			get 
			{
				return (ITextFieldWrapper)GetField("75577384-3c97-45da-a847-81b00500e250"); 
			} 
		} 	
	}
}
#endregion

