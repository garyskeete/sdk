﻿namespace CodeConverter.Common
{
    public class NodeVisitor
    {
        public virtual void VisitArrayCreation(ArrayCreation node)
        {
        }

        public virtual void VisitAssignment(Assignment node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }

        public virtual void VisitArgument(Argument node)
        {
            node.Expression.Accept(this);
        }

        public virtual void VisitArgumentList(ArgumentList argumentList)
        {
            foreach(var argument in argumentList.Arguments)
            {
                argument.Accept(this);
            }
        }

        public virtual void VisitBinaryExpression(BinaryExpression node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }

        public virtual void VisitBlock(Block node)
        {
            foreach(var statement in node.Statements)
            {
                statement.Accept(this);
            }
        }

        public virtual void VisitBracketedArgumentList(BracketedArgumentList node)
        {
            foreach (var argument in node.Arguments)
            {
                argument.Accept(this);
            }
        }

        public virtual void VisitBreak(Break node)
        {

        }

        public virtual void VisitCast(Cast node)
        {
            node.Expression.Accept(this);
        }

        public virtual void VisitCatch(Catch node)
        {
            node.Declaration.Accept(this);
            node.Block.Accept(this);
        }

        public virtual void VisitCatchDeclaration(CatchDeclaration node)
        {
        }

        public virtual void VisitClassDeclaration(ClassDeclaration node)
        {
            if (node == null) return;
            foreach(var member in node.Members)
            {
                if (member == null) continue;

                member.Accept(this);
            }
        }

        public virtual void VisitContinue(Continue node)
        {

        }

        public virtual void VisitElementAccess(ElementAccess node)
        {
            node.Expression.Accept(this);
            node.ArgumentList.Accept(this);
        }

        public virtual void VisitElseClause(ElseClause node)
        {
            node.Body.Accept(this);
        }

        public virtual void VisitForStatement(ForStatement node)
        {
            node.Declaration.Accept(this);
            foreach(var initializer in node.Initializers)
            {
                initializer.Accept(this);
            }
            node.Condition.Accept(this);
            foreach(var incrementor in node.Incrementors)
            {
                incrementor.Accept(this);
            }
            
            node.Statement.Accept(this);
        }

        public virtual void VisitFinally(Finally node)
        {
            node.Body.Accept(this);
        }

        public virtual void VisitForEachStatement(ForEachStatement node)
        {
            node.Statement.Accept(this);
            node.Expression.Accept(this);
        }

        public virtual void VisitIdentifierName(IdentifierName node)
        {
        }

        public virtual void VisitIfStatement(IfStatement node)
        {
            node.Condition.Accept(this);
            node.Body.Accept(this);
            node.ElseClause?.Accept(this);
        }

        public virtual void VisitInvocation(Invocation node)
        {
            node.Expression.Accept(this);
            node.Arguments.Accept(this);
        }

        public virtual void VisitLiteral(Literal node)
        {
        }

        public virtual void VisitMemberAccess(MemberAccess node)
        {
            node.Expression.Accept(this);
        }

        public virtual void VisitMethodDeclaration(MethodDeclaration node)
        {
            node.Body.Accept(this);
            foreach(var parameter in node.Parameters)
            {
                parameter.Accept(this);
            }
        }

        public virtual void VisitNamespace(Namespace node)
        {
            foreach(var member in node.Members)
            {
                member.Accept(this);
            }
        }

        public virtual void VisitObjectCreation(ObjectCreation node)
        {
            node.Arguments.Accept(this);
        }

        public virtual void VisitParameter(Parameter node)
        {
            
        }

        public virtual void VisitParenthesizedExpression(ParenthesizedExpression node)
        {
            node.Expression.Accept(this);
        }

        public virtual void VisitPostfixUnaryExpression(PostfixUnaryExpression node)
        {
            node.Operand.Accept(this);
        }

        public virtual void VisitPrefixUnaryExpression(PrefixUnaryExpression node)
        {
            node.Operand.Accept(this);
        }

        public virtual void VisitStringConstant(StringConstant node)
        {

        }

        public virtual void VisitTemplateStringConstant(TemplateStringConstant node)
        {

        }

        public virtual void VisitTry(Try node)
        {
            node.Block.Accept(this);
            foreach(var @catch in node.Catches)
            {
                @catch.Accept(this);
            }
        }

        public virtual void VisitUsing(Using node)
        {
            node.Declaration.Accept(this);
            node.Expression.Accept(this);
        }

        public virtual void VisitReturnStatement(ReturnStatement node)
        {
            node.Expression.Accept(this);
        }

        public virtual void VisitVariableDeclaration(VariableDeclaration node)
        {
            foreach(var variable in node.Variables)
            {
                variable.Accept(this);
            }
        }

        public virtual void VisitVariableDeclarator(VariableDeclarator node)
        {
            node.Initializer.Accept(this);
        }

        public virtual void VisitWhile(While node)
        {
            node.Condition.Accept(this);
            node.Statement.Accept(this);
        } 
    }
}
