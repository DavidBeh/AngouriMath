//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./Angourimath.g by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using System.Linq;
using System.Collections;
using AngouriMath;
using AngouriMath.Core;
using AngouriMath.Core.Numerix;
using System.Globalization;

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class AngourimathLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		NEWLINE=10, ID=11, NUMBER=12, COMMENT=13, WS=14;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"NEWLINE", "ID", "EXPONENT", "NUMBER", "COMMENT", "WS"
	};


	public AngourimathLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public AngourimathLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'!'", "'^'", "'-'", "'+'", "'*'", "'/'", "','", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "NEWLINE", 
		"ID", "NUMBER", "COMMENT", "WS"
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

	public override string GrammarFileName { get { return "Angourimath.g"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static AngourimathLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x10', '\x93', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x5', '\v', '\x35', '\n', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x6', '\f', ':', '\n', '\f', '\r', 
		'\f', '\xE', '\f', ';', '\x3', '\f', '\x3', '\f', '\x6', '\f', '@', '\n', 
		'\f', '\r', '\f', '\xE', '\f', '\x41', '\x5', '\f', '\x44', '\n', '\f', 
		'\x3', '\r', '\x3', '\r', '\x5', '\r', 'H', '\n', '\r', '\x3', '\r', '\x6', 
		'\r', 'K', '\n', '\r', '\r', '\r', '\xE', '\r', 'L', '\x3', '\xE', '\x6', 
		'\xE', 'P', '\n', '\xE', '\r', '\xE', '\xE', '\xE', 'Q', '\x3', '\xE', 
		'\x3', '\xE', '\a', '\xE', 'V', '\n', '\xE', '\f', '\xE', '\xE', '\xE', 
		'Y', '\v', '\xE', '\x3', '\xE', '\x5', '\xE', '\\', '\n', '\xE', '\x3', 
		'\xE', '\x5', '\xE', '_', '\n', '\xE', '\x3', '\xE', '\x5', '\xE', '\x62', 
		'\n', '\xE', '\x3', '\xE', '\x6', '\xE', '\x65', '\n', '\xE', '\r', '\xE', 
		'\xE', '\xE', '\x66', '\x3', '\xE', '\x5', '\xE', 'j', '\n', '\xE', '\x3', 
		'\xE', '\x5', '\xE', 'm', '\n', '\xE', '\x5', '\xE', 'o', '\n', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\a', '\xF', 'u', 
		'\n', '\xF', '\f', '\xF', '\xE', '\xF', 'x', '\v', '\xF', '\x3', '\xF', 
		'\x5', '\xF', '{', '\n', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\a', '\xF', '\x82', '\n', '\xF', '\f', '\xF', 
		'\xE', '\xF', '\x85', '\v', '\xF', '\x3', '\xF', '\x3', '\xF', '\x5', 
		'\xF', '\x89', '\n', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x6', '\x10', '\x8E', '\n', '\x10', '\r', '\x10', '\xE', '\x10', '\x8F', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x83', '\x2', '\x11', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\x2', '\x1B', '\xE', '\x1D', '\xF', '\x1F', '\x10', '\x3', '\x2', '\b', 
		'\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', 
		'\\', '\x63', '|', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', '-', 
		'-', '/', '/', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x4', '\x2', '\v', 
		'\v', '\"', '\"', '\x2', '\xA5', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x3', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '#', '\x3', '\x2', '\x2', '\x2', '\a', '%', '\x3', '\x2', '\x2', 
		'\x2', '\t', '\'', '\x3', '\x2', '\x2', '\x2', '\v', ')', '\x3', '\x2', 
		'\x2', '\x2', '\r', '+', '\x3', '\x2', '\x2', '\x2', '\xF', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '/', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x15', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x39', '\x3', '\x2', '\x2', '\x2', '\x19', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', 'n', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\x88', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x8D', '\x3', '\x2', '\x2', 
		'\x2', '!', '\"', '\a', '#', '\x2', '\x2', '\"', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '#', '$', '\a', '`', '\x2', '\x2', '$', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '%', '&', '\a', '/', '\x2', '\x2', '&', '\b', '\x3', '\x2', 
		'\x2', '\x2', '\'', '(', '\a', '-', '\x2', '\x2', '(', '\n', '\x3', '\x2', 
		'\x2', '\x2', ')', '*', '\a', ',', '\x2', '\x2', '*', '\f', '\x3', '\x2', 
		'\x2', '\x2', '+', ',', '\a', '\x31', '\x2', '\x2', ',', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '-', '.', '\a', '.', '\x2', '\x2', '.', '\x10', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x30', '\a', '*', '\x2', '\x2', '\x30', '\x12', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\x32', '\a', '+', '\x2', '\x2', '\x32', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x33', '\x35', '\a', '\xF', '\x2', 
		'\x2', '\x34', '\x33', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x36', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x37', '\a', '\f', '\x2', '\x2', '\x37', '\x16', '\x3', '\x2', '\x2', 
		'\x2', '\x38', ':', '\t', '\x2', '\x2', '\x2', '\x39', '\x38', '\x3', 
		'\x2', '\x2', '\x2', ':', ';', '\x3', '\x2', '\x2', '\x2', ';', '\x39', 
		'\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', '<', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '=', '?', '\a', '\x61', '\x2', '\x2', 
		'>', '@', '\t', '\x3', '\x2', '\x2', '?', '>', '\x3', '\x2', '\x2', '\x2', 
		'@', '\x41', '\x3', '\x2', '\x2', '\x2', '\x41', '?', '\x3', '\x2', '\x2', 
		'\x2', '\x41', '\x42', '\x3', '\x2', '\x2', '\x2', '\x42', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '=', '\x3', '\x2', '\x2', '\x2', '\x43', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\x44', '\x18', '\x3', '\x2', '\x2', 
		'\x2', '\x45', 'G', '\t', '\x4', '\x2', '\x2', '\x46', 'H', '\t', '\x5', 
		'\x2', '\x2', 'G', '\x46', '\x3', '\x2', '\x2', '\x2', 'G', 'H', '\x3', 
		'\x2', '\x2', '\x2', 'H', 'J', '\x3', '\x2', '\x2', '\x2', 'I', 'K', '\x4', 
		'\x32', ';', '\x2', 'J', 'I', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\x3', 
		'\x2', '\x2', '\x2', 'L', 'J', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\x3', 
		'\x2', '\x2', '\x2', 'M', '\x1A', '\x3', '\x2', '\x2', '\x2', 'N', 'P', 
		'\x4', '\x32', ';', '\x2', 'O', 'N', '\x3', '\x2', '\x2', '\x2', 'P', 
		'Q', '\x3', '\x2', '\x2', '\x2', 'Q', 'O', '\x3', '\x2', '\x2', '\x2', 
		'Q', 'R', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\x3', '\x2', '\x2', '\x2', 
		'S', 'W', '\a', '\x30', '\x2', '\x2', 'T', 'V', '\x4', '\x32', ';', '\x2', 
		'U', 'T', '\x3', '\x2', '\x2', '\x2', 'V', 'Y', '\x3', '\x2', '\x2', '\x2', 
		'W', 'U', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\x3', '\x2', '\x2', '\x2', 
		'X', '[', '\x3', '\x2', '\x2', '\x2', 'Y', 'W', '\x3', '\x2', '\x2', '\x2', 
		'Z', '\\', '\x5', '\x19', '\r', '\x2', '[', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '[', '\\', '\x3', '\x2', '\x2', '\x2', '\\', '^', '\x3', '\x2', 
		'\x2', '\x2', ']', '_', '\a', 'k', '\x2', '\x2', '^', ']', '\x3', '\x2', 
		'\x2', '\x2', '^', '_', '\x3', '\x2', '\x2', '\x2', '_', 'o', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x62', '\a', '\x30', '\x2', '\x2', '\x61', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x62', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'\x64', '\x3', '\x2', '\x2', '\x2', '\x63', '\x65', '\x4', '\x32', ';', 
		'\x2', '\x64', '\x63', '\x3', '\x2', '\x2', '\x2', '\x65', '\x66', '\x3', 
		'\x2', '\x2', '\x2', '\x66', '\x64', '\x3', '\x2', '\x2', '\x2', '\x66', 
		'g', '\x3', '\x2', '\x2', '\x2', 'g', 'i', '\x3', '\x2', '\x2', '\x2', 
		'h', 'j', '\x5', '\x19', '\r', '\x2', 'i', 'h', '\x3', '\x2', '\x2', '\x2', 
		'i', 'j', '\x3', '\x2', '\x2', '\x2', 'j', 'l', '\x3', '\x2', '\x2', '\x2', 
		'k', 'm', '\a', 'k', '\x2', '\x2', 'l', 'k', '\x3', '\x2', '\x2', '\x2', 
		'l', 'm', '\x3', '\x2', '\x2', '\x2', 'm', 'o', '\x3', '\x2', '\x2', '\x2', 
		'n', 'O', '\x3', '\x2', '\x2', '\x2', 'n', '\x61', '\x3', '\x2', '\x2', 
		'\x2', 'o', '\x1C', '\x3', '\x2', '\x2', '\x2', 'p', 'q', '\a', '\x31', 
		'\x2', '\x2', 'q', 'r', '\a', '\x31', '\x2', '\x2', 'r', 'v', '\x3', '\x2', 
		'\x2', '\x2', 's', 'u', '\n', '\x6', '\x2', '\x2', 't', 's', '\x3', '\x2', 
		'\x2', '\x2', 'u', 'x', '\x3', '\x2', '\x2', '\x2', 'v', 't', '\x3', '\x2', 
		'\x2', '\x2', 'v', 'w', '\x3', '\x2', '\x2', '\x2', 'w', 'z', '\x3', '\x2', 
		'\x2', '\x2', 'x', 'v', '\x3', '\x2', '\x2', '\x2', 'y', '{', '\a', '\xF', 
		'\x2', '\x2', 'z', 'y', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\x3', '\x2', 
		'\x2', '\x2', '{', '|', '\x3', '\x2', '\x2', '\x2', '|', '\x89', '\a', 
		'\f', '\x2', '\x2', '}', '~', '\a', '\x31', '\x2', '\x2', '~', '\x7F', 
		'\a', ',', '\x2', '\x2', '\x7F', '\x83', '\x3', '\x2', '\x2', '\x2', '\x80', 
		'\x82', '\v', '\x2', '\x2', '\x2', '\x81', '\x80', '\x3', '\x2', '\x2', 
		'\x2', '\x82', '\x85', '\x3', '\x2', '\x2', '\x2', '\x83', '\x84', '\x3', 
		'\x2', '\x2', '\x2', '\x83', '\x81', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x86', '\x3', '\x2', '\x2', '\x2', '\x85', '\x83', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x87', '\a', ',', '\x2', '\x2', '\x87', '\x89', '\a', 
		'\x31', '\x2', '\x2', '\x88', 'p', '\x3', '\x2', '\x2', '\x2', '\x88', 
		'}', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\x8A', '\x8B', '\b', '\xF', '\x2', '\x2', '\x8B', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x8C', '\x8E', '\t', '\a', '\x2', '\x2', '\x8D', 
		'\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\x3', '\x2', '\x2', 
		'\x2', '\x8F', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', 
		'\x2', '\x2', '\x2', '\x90', '\x91', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x92', '\b', '\x10', '\x2', '\x2', '\x92', ' ', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x2', '\x34', ';', '\x41', '\x43', 'G', 'L', 'Q', 'W', 
		'[', '^', '\x61', '\x66', 'i', 'l', 'n', 'v', 'z', '\x83', '\x88', '\x8F', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
