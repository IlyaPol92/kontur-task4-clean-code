﻿using System;

namespace Markdown.Parsers.Tokens.Tags
{
    public abstract class Tag : Token
    {
        protected Tag(string data) : base(data)
        {
        }

        public virtual bool TryToValidate(MarkdownParsingLine context) =>
            IsValidTag(context.Line, context.CurrentPosition);

        protected virtual bool IsValidTag(string currentLine, int position)
        {
            throw new NotImplementedException();
        }
    }
}
