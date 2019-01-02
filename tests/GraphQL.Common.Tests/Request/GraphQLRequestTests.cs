using Xunit;

namespace GraphQL.Common.Tests.Request {

	public class GraphQLRequestTests {

		[Fact]
		public void FieldsRequest1Fact() {
			var graphQLRequest = GraphQLRequestConsts.FieldsRequest1;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void FieldsRequest2Fact() {
			var graphQLRequest = GraphQLRequestConsts.FieldsRequest2;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void ArgumentsRequest1Fact() {
			var graphQLRequest = GraphQLRequestConsts.ArgumentsRequest1;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void ArgumentsRequest2Fact() {
			var graphQLRequest = GraphQLRequestConsts.ArgumentsRequest2;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void AliasesRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.AliasesRequest;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void FragmentsRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.FragmentsRequest;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void OperationNameRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.OperationNameRequest;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

		[Fact]
		public void VariablesRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.VariablesRequest;
			dynamic variables = graphQLRequest.Variables;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
			Assert.NotNull(variables);
			Assert.Equal("JEDI", variables.episode);
		}

		[Fact]
		public void DirectivesRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.DirectivesRequest;
			dynamic variables = graphQLRequest.Variables;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
			Assert.NotNull(variables);
			Assert.Equal("JEDI", variables.episode);
			Assert.Equal(false, variables.withFriends);
		}

		[Fact]
		public void MutationsRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.MutationsRequest;
			dynamic variables = graphQLRequest.Variables;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
			Assert.NotNull(variables);
			Assert.Equal("JEDI", variables.ep);
			Assert.Equal(5, variables.review.stars);
			Assert.Equal("This is a great movie!", variables.review.commentary);
		}

		[Fact]
		public void InlineFragmentsRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.InlineFragmentsRequest;
			dynamic variables = graphQLRequest.Variables;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
			Assert.NotNull(variables);
			Assert.Equal("JEDI", variables.ep);
		}

		[Fact]
		public void MetaFieldsRequestFact() {
			var graphQLRequest = GraphQLRequestConsts.MetaFieldsRequest;
			AssertGraphQL.CorrectGraphQLRequest(graphQLRequest);
		}

	}

}
