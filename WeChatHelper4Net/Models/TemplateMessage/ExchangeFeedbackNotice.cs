﻿using System;

/*
 * 微信公众账号API，发送模板消息模型
 * 作者：熊学浩
 * 时间：2015-10-26
 */
namespace WeChatHelper4Net.Models.TemplateMessage
{
	/// <summary>
	/// 最新学术交流意见反馈通知
	/// </summary>
	public class ExchangeFeedbackNotice : Base
	{
		private ExchangeFeedbackNoticeData _data;
		public ExchangeFeedbackNoticeData data { get { return _data; } set { _data = value; } }
	}

	public class ExchangeFeedbackNoticeData : DataBase
	{
		private DataItem _keyword1;
		private DataItem _keyword2;
		private DataItem _keyword3;
		private DataItem _keyword4;

		/// <summary>
		/// 反馈人
		/// </summary>
		public DataItem keyword1 { get { return _keyword1; } set { _keyword1 = value; } }
		/// <summary>
		/// 反馈主题
		/// </summary>
		public DataItem keyword2 { get { return _keyword2; } set { _keyword2 = value; } }
		/// <summary>
		/// 反馈内容
		/// </summary>
		public DataItem keyword3 { get { return _keyword3; } set { _keyword3 = value; } }
		/// <summary>
		/// 反馈时间
		/// </summary>
		public DataItem keyword4 { get { return _keyword4; } set { _keyword4 = value; } }
	}
}
