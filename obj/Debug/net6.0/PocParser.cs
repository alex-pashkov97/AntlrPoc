//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/alex/Projects/Antlr/Poc.g4 by ANTLR 4.9.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class PocParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, IDENTIFIER=21, INT=22, DOUBLE=23, WS=24;
	public const int
		RULE_prog = 0, RULE_statement = 1, RULE_ifStatement = 2, RULE_loopStatement = 3, 
		RULE_methodCall = 4, RULE_expression = 5;
	public static readonly string[] ruleNames = {
		"prog", "statement", "ifStatement", "loopStatement", "methodCall", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'('", "')'", "'{'", "'}'", "'else'", "'while'", 
		"'PushToOrder'", "'CallExternal'", "'task'", "'true'", "'.'", "'false'", 
		"'<'", "'>'", "'<='", "'>='", "'=='", "'!='"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, "IDENTIFIER", "INT", 
		"DOUBLE", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Poc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PocParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public PocParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public PocParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public ProgContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_prog; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterProg(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitProg(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProg(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgContext prog() {
		ProgContext _localctx = new ProgContext(Context, State);
		EnterRule(_localctx, 0, RULE_prog);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 15;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << T__7) | (1L << T__8) | (1L << T__9))) != 0)) {
				{
				{
				State = 12;
				statement();
				}
				}
				State = 17;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public MethodCallContext methodCall() {
			return GetRuleContext<MethodCallContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IfStatementContext ifStatement() {
			return GetRuleContext<IfStatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public LoopStatementContext loopStatement() {
			return GetRuleContext<LoopStatementContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		int _la;
		try {
			State = 24;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__8:
			case T__9:
				EnterOuterAlt(_localctx, 1);
				{
				State = 18;
				methodCall();
				State = 20;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__0) {
					{
					State = 19;
					Match(T__0);
					}
				}

				}
				break;
			case T__1:
				EnterOuterAlt(_localctx, 2);
				{
				State = 22;
				ifStatement();
				}
				break;
			case T__7:
				EnterOuterAlt(_localctx, 3);
				{
				State = 23;
				loopStatement();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IfStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public IfStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_ifStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterIfStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitIfStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIfStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IfStatementContext ifStatement() {
		IfStatementContext _localctx = new IfStatementContext(Context, State);
		EnterRule(_localctx, 4, RULE_ifStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 26;
			Match(T__1);
			State = 27;
			Match(T__2);
			State = 28;
			expression(0);
			State = 29;
			Match(T__3);
			State = 30;
			Match(T__4);
			State = 34;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << T__7) | (1L << T__8) | (1L << T__9))) != 0)) {
				{
				{
				State = 31;
				statement();
				}
				}
				State = 36;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 37;
			Match(T__5);
			State = 47;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__6) {
				{
				State = 38;
				Match(T__6);
				State = 39;
				Match(T__4);
				State = 43;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << T__7) | (1L << T__8) | (1L << T__9))) != 0)) {
					{
					{
					State = 40;
					statement();
					}
					}
					State = 45;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 46;
				Match(T__5);
				}
			}

			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LoopStatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		public LoopStatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_loopStatement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterLoopStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitLoopStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLoopStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LoopStatementContext loopStatement() {
		LoopStatementContext _localctx = new LoopStatementContext(Context, State);
		EnterRule(_localctx, 6, RULE_loopStatement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49;
			Match(T__7);
			State = 50;
			Match(T__2);
			State = 51;
			expression(0);
			State = 52;
			Match(T__3);
			State = 53;
			Match(T__4);
			State = 57;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__1) | (1L << T__7) | (1L << T__8) | (1L << T__9))) != 0)) {
				{
				{
				State = 54;
				statement();
				}
				}
				State = 59;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 60;
			Match(T__5);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodCallContext : ParserRuleContext {
		public MethodCallContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodCall; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterMethodCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitMethodCall(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMethodCall(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MethodCallContext methodCall() {
		MethodCallContext _localctx = new MethodCallContext(Context, State);
		EnterRule(_localctx, 8, RULE_methodCall);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 62;
			_la = TokenStream.LA(1);
			if ( !(_la==T__8 || _la==T__9) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			State = 63;
			Match(T__2);
			State = 64;
			Match(T__10);
			State = 65;
			Match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] IDENTIFIER() { return GetTokens(PocParser.IDENTIFIER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IDENTIFIER(int i) {
			return GetToken(PocParser.IDENTIFIER, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(PocParser.INT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DOUBLE() { return GetToken(PocParser.DOUBLE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.EnterExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IPocListener typedListener = listener as IPocListener;
			if (typedListener != null) typedListener.ExitExpression(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IPocVisitor<TResult> typedVisitor = visitor as IPocVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpression(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 80;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case T__11:
				{
				State = 68;
				Match(T__11);
				}
				break;
			case IDENTIFIER:
				{
				State = 69;
				Match(IDENTIFIER);
				State = 74;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
				while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						State = 70;
						Match(T__12);
						State = 71;
						Match(IDENTIFIER);
						}
						} 
					}
					State = 76;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
				}
				}
				break;
			case T__13:
				{
				State = 77;
				Match(T__13);
				}
				break;
			case INT:
				{
				State = 78;
				Match(INT);
				}
				break;
			case DOUBLE:
				{
				State = 79;
				Match(DOUBLE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 86;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					{
					_localctx = new ExpressionContext(_parentctx, _parentState);
					PushNewRecursionContext(_localctx, _startState, RULE_expression);
					State = 82;
					if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
					State = 83;
					_la = TokenStream.LA(1);
					if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__14) | (1L << T__15) | (1L << T__16) | (1L << T__17) | (1L << T__18) | (1L << T__19))) != 0)) ) {
					ErrorHandler.RecoverInline(this);
					}
					else {
						ErrorHandler.ReportMatch(this);
					    Consume();
					}
					}
					} 
				}
				State = 88;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5: return expression_sempred((ExpressionContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 1);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1A', '\\', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\a', '\x2', 
		'\x10', '\n', '\x2', '\f', '\x2', '\xE', '\x2', '\x13', '\v', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '\x17', '\n', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '\x1B', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', 
		'#', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '&', '\v', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\a', '\x4', ',', '\n', 
		'\x4', '\f', '\x4', '\xE', '\x4', '/', '\v', '\x4', '\x3', '\x4', '\x5', 
		'\x4', '\x32', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\a', '\x5', ':', '\n', '\x5', 
		'\f', '\x5', '\xE', '\x5', '=', '\v', '\x5', '\x3', '\x5', '\x3', '\x5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\a', 
		'\a', 'K', '\n', '\a', '\f', '\a', '\xE', '\a', 'N', '\v', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', 'S', '\n', '\a', '\x3', '\a', 
		'\x3', '\a', '\a', '\a', 'W', '\n', '\a', '\f', '\a', '\xE', '\a', 'Z', 
		'\v', '\a', '\x3', '\a', '\x2', '\x3', '\f', '\b', '\x2', '\x4', '\x6', 
		'\b', '\n', '\f', '\x2', '\x4', '\x3', '\x2', '\v', '\f', '\x3', '\x2', 
		'\x11', '\x16', '\x2', '\x63', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x4', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x6', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\b', '\x33', '\x3', '\x2', '\x2', '\x2', '\n', '@', '\x3', 
		'\x2', '\x2', '\x2', '\f', 'R', '\x3', '\x2', '\x2', '\x2', '\xE', '\x10', 
		'\x5', '\x4', '\x3', '\x2', '\xF', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x10', '\x13', '\x3', '\x2', '\x2', '\x2', '\x11', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x12', '\x3', '\x2', '\x2', '\x2', '\x12', '\x3', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x14', '\x16', '\x5', '\n', '\x6', '\x2', '\x15', '\x17', '\a', '\x3', 
		'\x2', '\x2', '\x16', '\x15', '\x3', '\x2', '\x2', '\x2', '\x16', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x1B', '\x5', '\x6', '\x4', '\x2', '\x19', '\x1B', '\x5', '\b', 
		'\x5', '\x2', '\x1A', '\x14', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x18', 
		'\x3', '\x2', '\x2', '\x2', '\x1A', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\x5', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\a', '\x4', 
		'\x2', '\x2', '\x1D', '\x1E', '\a', '\x5', '\x2', '\x2', '\x1E', '\x1F', 
		'\x5', '\f', '\a', '\x2', '\x1F', ' ', '\a', '\x6', '\x2', '\x2', ' ', 
		'$', '\a', '\a', '\x2', '\x2', '!', '#', '\x5', '\x4', '\x3', '\x2', '\"', 
		'!', '\x3', '\x2', '\x2', '\x2', '#', '&', '\x3', '\x2', '\x2', '\x2', 
		'$', '\"', '\x3', '\x2', '\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', 
		'\x2', '%', '\'', '\x3', '\x2', '\x2', '\x2', '&', '$', '\x3', '\x2', 
		'\x2', '\x2', '\'', '\x31', '\a', '\b', '\x2', '\x2', '(', ')', '\a', 
		'\t', '\x2', '\x2', ')', '-', '\a', '\a', '\x2', '\x2', '*', ',', '\x5', 
		'\x4', '\x3', '\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '/', '\x3', 
		'\x2', '\x2', '\x2', '-', '+', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', 
		'\x2', '\x2', '\x2', '.', '\x30', '\x3', '\x2', '\x2', '\x2', '/', '-', 
		'\x3', '\x2', '\x2', '\x2', '\x30', '\x32', '\a', '\b', '\x2', '\x2', 
		'\x31', '(', '\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\x32', '\a', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', '\n', '\x2', '\x2', '\x34', '\x35', '\a', '\x5', '\x2', '\x2', '\x35', 
		'\x36', '\x5', '\f', '\a', '\x2', '\x36', '\x37', '\a', '\x6', '\x2', 
		'\x2', '\x37', ';', '\a', '\a', '\x2', '\x2', '\x38', ':', '\x5', '\x4', 
		'\x3', '\x2', '\x39', '\x38', '\x3', '\x2', '\x2', '\x2', ':', '=', '\x3', 
		'\x2', '\x2', '\x2', ';', '\x39', '\x3', '\x2', '\x2', '\x2', ';', '<', 
		'\x3', '\x2', '\x2', '\x2', '<', '>', '\x3', '\x2', '\x2', '\x2', '=', 
		';', '\x3', '\x2', '\x2', '\x2', '>', '?', '\a', '\b', '\x2', '\x2', '?', 
		'\t', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\t', '\x2', '\x2', '\x2', 
		'\x41', '\x42', '\a', '\x5', '\x2', '\x2', '\x42', '\x43', '\a', '\r', 
		'\x2', '\x2', '\x43', '\x44', '\a', '\x6', '\x2', '\x2', '\x44', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\b', '\a', '\x1', '\x2', 
		'\x46', 'S', '\a', '\xE', '\x2', '\x2', 'G', 'L', '\a', '\x17', '\x2', 
		'\x2', 'H', 'I', '\a', '\xF', '\x2', '\x2', 'I', 'K', '\a', '\x17', '\x2', 
		'\x2', 'J', 'H', '\x3', '\x2', '\x2', '\x2', 'K', 'N', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'J', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\x3', '\x2', '\x2', 
		'\x2', 'M', 'S', '\x3', '\x2', '\x2', '\x2', 'N', 'L', '\x3', '\x2', '\x2', 
		'\x2', 'O', 'S', '\a', '\x10', '\x2', '\x2', 'P', 'S', '\a', '\x18', '\x2', 
		'\x2', 'Q', 'S', '\a', '\x19', '\x2', '\x2', 'R', '\x45', '\x3', '\x2', 
		'\x2', '\x2', 'R', 'G', '\x3', '\x2', '\x2', '\x2', 'R', 'O', '\x3', '\x2', 
		'\x2', '\x2', 'R', 'P', '\x3', '\x2', '\x2', '\x2', 'R', 'Q', '\x3', '\x2', 
		'\x2', '\x2', 'S', 'X', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\f', '\x3', 
		'\x2', '\x2', 'U', 'W', '\t', '\x3', '\x2', '\x2', 'V', 'T', '\x3', '\x2', 
		'\x2', '\x2', 'W', 'Z', '\x3', '\x2', '\x2', '\x2', 'X', 'V', '\x3', '\x2', 
		'\x2', '\x2', 'X', 'Y', '\x3', '\x2', '\x2', '\x2', 'Y', '\r', '\x3', 
		'\x2', '\x2', '\x2', 'Z', 'X', '\x3', '\x2', '\x2', '\x2', '\f', '\x11', 
		'\x16', '\x1A', '$', '-', '\x31', ';', 'L', 'R', 'X',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Antlr
