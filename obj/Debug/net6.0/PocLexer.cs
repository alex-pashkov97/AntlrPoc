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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.3")]
[System.CLSCompliant(false)]
public partial class PocLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, IDENTIFIER=21, INT=22, DOUBLE=23, WS=24;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "IDENTIFIER", "INT", "DOUBLE", "WS"
	};


	public PocLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public PocLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static PocLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1A', '\xA4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x3', '\x16', '\a', '\x16', '\x89', '\n', '\x16', 
		'\f', '\x16', '\xE', '\x16', '\x8C', '\v', '\x16', '\x3', '\x17', '\x6', 
		'\x17', '\x8F', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x90', '\x3', 
		'\x18', '\x6', '\x18', '\x94', '\n', '\x18', '\r', '\x18', '\xE', '\x18', 
		'\x95', '\x3', '\x18', '\x3', '\x18', '\x6', '\x18', '\x9A', '\n', '\x18', 
		'\r', '\x18', '\xE', '\x18', '\x9B', '\x3', '\x19', '\x6', '\x19', '\x9F', 
		'\n', '\x19', '\r', '\x19', '\xE', '\x19', '\xA0', '\x3', '\x19', '\x3', 
		'\x19', '\x2', '\x2', '\x1A', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', 
		'\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', 
		'\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', 
		'\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', 
		')', '\x16', '+', '\x17', '-', '\x18', '/', '\x19', '\x31', '\x1A', '\x3', 
		'\x2', '\x6', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', 
		'\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', 
		'\x3', '\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', 
		'\"', '\x2', '\xA8', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x33', '\x3', '\x2', '\x2', '\x2', '\x5', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\a', '\x38', '\x3', '\x2', '\x2', '\x2', '\t', ':', '\x3', 
		'\x2', '\x2', '\x2', '\v', '<', '\x3', '\x2', '\x2', '\x2', '\r', '>', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '@', '\x3', '\x2', '\x2', '\x2', '\x11', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x13', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x15', 'W', '\x3', '\x2', '\x2', '\x2', '\x17', '\x64', '\x3', 
		'\x2', '\x2', '\x2', '\x19', 'i', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'n', '\x3', '\x2', '\x2', '\x2', '\x1D', 'p', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', 'v', '\x3', '\x2', '\x2', '\x2', '!', 'x', '\x3', '\x2', '\x2', 
		'\x2', '#', 'z', '\x3', '\x2', '\x2', '\x2', '%', '}', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x80', '\x3', '\x2', '\x2', '\x2', ')', '\x83', '\x3', '\x2', 
		'\x2', '\x2', '+', '\x86', '\x3', '\x2', '\x2', '\x2', '-', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x93', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x9E', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\a', '=', '\x2', 
		'\x2', '\x34', '\x4', '\x3', '\x2', '\x2', '\x2', '\x35', '\x36', '\a', 
		'k', '\x2', '\x2', '\x36', '\x37', '\a', 'h', '\x2', '\x2', '\x37', '\x6', 
		'\x3', '\x2', '\x2', '\x2', '\x38', '\x39', '\a', '*', '\x2', '\x2', '\x39', 
		'\b', '\x3', '\x2', '\x2', '\x2', ':', ';', '\a', '+', '\x2', '\x2', ';', 
		'\n', '\x3', '\x2', '\x2', '\x2', '<', '=', '\a', '}', '\x2', '\x2', '=', 
		'\f', '\x3', '\x2', '\x2', '\x2', '>', '?', '\a', '\x7F', '\x2', '\x2', 
		'?', '\xE', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\a', 'g', '\x2', 
		'\x2', '\x41', '\x42', '\a', 'n', '\x2', '\x2', '\x42', '\x43', '\a', 
		'u', '\x2', '\x2', '\x43', '\x44', '\a', 'g', '\x2', '\x2', '\x44', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\x46', '\a', 'y', '\x2', '\x2', '\x46', 
		'G', '\a', 'j', '\x2', '\x2', 'G', 'H', '\a', 'k', '\x2', '\x2', 'H', 
		'I', '\a', 'n', '\x2', '\x2', 'I', 'J', '\a', 'g', '\x2', '\x2', 'J', 
		'\x12', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', 'R', '\x2', '\x2', 
		'L', 'M', '\a', 'w', '\x2', '\x2', 'M', 'N', '\a', 'u', '\x2', '\x2', 
		'N', 'O', '\a', 'j', '\x2', '\x2', 'O', 'P', '\a', 'V', '\x2', '\x2', 
		'P', 'Q', '\a', 'q', '\x2', '\x2', 'Q', 'R', '\a', 'Q', '\x2', '\x2', 
		'R', 'S', '\a', 't', '\x2', '\x2', 'S', 'T', '\a', '\x66', '\x2', '\x2', 
		'T', 'U', '\a', 'g', '\x2', '\x2', 'U', 'V', '\a', 't', '\x2', '\x2', 
		'V', '\x14', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', '\x45', '\x2', 
		'\x2', 'X', 'Y', '\a', '\x63', '\x2', '\x2', 'Y', 'Z', '\a', 'n', '\x2', 
		'\x2', 'Z', '[', '\a', 'n', '\x2', '\x2', '[', '\\', '\a', 'G', '\x2', 
		'\x2', '\\', ']', '\a', 'z', '\x2', '\x2', ']', '^', '\a', 'v', '\x2', 
		'\x2', '^', '_', '\a', 'g', '\x2', '\x2', '_', '`', '\a', 't', '\x2', 
		'\x2', '`', '\x61', '\a', 'p', '\x2', '\x2', '\x61', '\x62', '\a', '\x63', 
		'\x2', '\x2', '\x62', '\x63', '\a', 'n', '\x2', '\x2', '\x63', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', 'v', '\x2', '\x2', '\x65', 
		'\x66', '\a', '\x63', '\x2', '\x2', '\x66', 'g', '\a', 'u', '\x2', '\x2', 
		'g', 'h', '\a', 'm', '\x2', '\x2', 'h', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'i', 'j', '\a', 'v', '\x2', '\x2', 'j', 'k', '\a', 't', '\x2', '\x2', 
		'k', 'l', '\a', 'w', '\x2', '\x2', 'l', 'm', '\a', 'g', '\x2', '\x2', 
		'm', '\x1A', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', '\x30', '\x2', 
		'\x2', 'o', '\x1C', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', 'h', '\x2', 
		'\x2', 'q', 'r', '\a', '\x63', '\x2', '\x2', 'r', 's', '\a', 'n', '\x2', 
		'\x2', 's', 't', '\a', 'u', '\x2', '\x2', 't', 'u', '\a', 'g', '\x2', 
		'\x2', 'u', '\x1E', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', '>', '\x2', 
		'\x2', 'w', ' ', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', '@', '\x2', 
		'\x2', 'y', '\"', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', '>', '\x2', 
		'\x2', '{', '|', '\a', '?', '\x2', '\x2', '|', '$', '\x3', '\x2', '\x2', 
		'\x2', '}', '~', '\a', '@', '\x2', '\x2', '~', '\x7F', '\a', '?', '\x2', 
		'\x2', '\x7F', '&', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', 
		'?', '\x2', '\x2', '\x81', '\x82', '\a', '?', '\x2', '\x2', '\x82', '(', 
		'\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\a', '#', '\x2', '\x2', '\x84', 
		'\x85', '\a', '?', '\x2', '\x2', '\x85', '*', '\x3', '\x2', '\x2', '\x2', 
		'\x86', '\x8A', '\t', '\x2', '\x2', '\x2', '\x87', '\x89', '\t', '\x3', 
		'\x2', '\x2', '\x88', '\x87', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8C', 
		'\x3', '\x2', '\x2', '\x2', '\x8A', '\x88', '\x3', '\x2', '\x2', '\x2', 
		'\x8A', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8B', ',', '\x3', '\x2', 
		'\x2', '\x2', '\x8C', '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8F', 
		'\t', '\x4', '\x2', '\x2', '\x8E', '\x8D', '\x3', '\x2', '\x2', '\x2', 
		'\x8F', '\x90', '\x3', '\x2', '\x2', '\x2', '\x90', '\x8E', '\x3', '\x2', 
		'\x2', '\x2', '\x90', '\x91', '\x3', '\x2', '\x2', '\x2', '\x91', '.', 
		'\x3', '\x2', '\x2', '\x2', '\x92', '\x94', '\t', '\x4', '\x2', '\x2', 
		'\x93', '\x92', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\x3', '\x2', 
		'\x2', '\x2', '\x95', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\x3', '\x2', '\x2', '\x2', 
		'\x97', '\x99', '\a', '\x30', '\x2', '\x2', '\x98', '\x9A', '\t', '\x4', 
		'\x2', '\x2', '\x99', '\x98', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x9B', 
		'\x3', '\x2', '\x2', '\x2', '\x9B', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x9B', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\x9D', '\x9F', '\t', '\x5', '\x2', '\x2', '\x9E', '\x9D', 
		'\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\x3', '\x2', '\x2', '\x2', 
		'\xA0', '\x9E', '\x3', '\x2', '\x2', '\x2', '\xA0', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA3', 
		'\b', '\x19', '\x2', '\x2', '\xA3', '\x32', '\x3', '\x2', '\x2', '\x2', 
		'\b', '\x2', '\x8A', '\x90', '\x95', '\x9B', '\xA0', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Antlr
