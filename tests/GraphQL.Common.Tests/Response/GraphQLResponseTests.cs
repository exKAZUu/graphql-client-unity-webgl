using GraphQL.Common.Tests.Model;
using Xunit;

namespace GraphQL.Common.Tests.Response {

	public class GraphQLResponseTests {

		[Fact]
		public void FieldsResponse1Fact() {
			var graphQLResponse = GraphQLResponseConsts.FieldsResponse1;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
		}

		[Fact]
		public void FieldsResponse2Fact() {
			var graphQLResponse = GraphQLResponseConsts.FieldsResponse2;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);
			Assert.Equal("Luke Skywalker", data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void ArgumentsResponse1Fact() {
			var graphQLResponse = GraphQLResponseConsts.ArgumentsResponse1;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", data.human.name.Value);
			Assert.Equal(1.72, data.human.height.Value);

			var human = graphQLResponse.GetDataFieldAs<Person>("human");
			Assert.Equal("Luke Skywalker", human.Name);
			Assert.Equal(1.72, human.Height);
		}

		[Fact]
		public void ArgumentsResponse2Fact() {
			var graphQLResponse = GraphQLResponseConsts.ArgumentsResponse2;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", data.human.name.Value);
			Assert.Equal(5.6430448, data.human.height.Value);

			var human = graphQLResponse.GetDataFieldAs<Person>("human");
			Assert.Equal("Luke Skywalker", human.Name);
			Assert.Equal(5.6430448, human.Height);
		}

		[Fact]
		public void AliasesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.AliasesResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", data.empireHero.name.Value);
			Assert.Equal("R2-D2", data.jediHero.name.Value);

			var empireHero = graphQLResponse.GetDataFieldAs<Person>("empireHero");
			Assert.Equal("Luke Skywalker", empireHero.Name);

			var jediHero = graphQLResponse.GetDataFieldAs<Person>("jediHero");
			Assert.Equal("R2-D2", jediHero.Name);
		}

		[Fact]
		public void FragmentsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.FragmentsResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", data.leftComparison.name.Value);
			Assert.Equal("NEWHOPE", data.leftComparison.appearsIn[0].Value);
			Assert.Equal("EMPIRE", data.leftComparison.appearsIn[1].Value);
			Assert.Equal("JEDI", data.leftComparison.appearsIn[2].Value);
			Assert.Equal("Han Solo", data.leftComparison.friends[0].name.Value);
			Assert.Equal("Leia Organa", data.leftComparison.friends[1].name.Value);
			Assert.Equal("C-3PO", data.leftComparison.friends[2].name.Value);
			Assert.Equal("R2-D2", data.leftComparison.friends[3].name.Value);

			Assert.Equal("R2-D2", data.rightComparison.name.Value);
			Assert.Equal("NEWHOPE", data.rightComparison.appearsIn[0].Value);
			Assert.Equal("EMPIRE", data.rightComparison.appearsIn[1].Value);
			Assert.Equal("JEDI", data.rightComparison.appearsIn[2].Value);
			Assert.Equal("Luke Skywalker", data.rightComparison.friends[0].name.Value);
			Assert.Equal("Han Solo", data.rightComparison.friends[1].name.Value);
			Assert.Equal("Leia Organa", data.rightComparison.friends[2].name.Value);

			var leftComparison = graphQLResponse.GetDataFieldAs<Person>("leftComparison");
			Assert.Equal("Luke Skywalker", leftComparison.Name);
			Assert.Equal("NEWHOPE", leftComparison.AppearsIn[0]);
			Assert.Equal("EMPIRE", leftComparison.AppearsIn[1]);
			Assert.Equal("JEDI", leftComparison.AppearsIn[2]);
			Assert.Equal("Han Solo", leftComparison.Friends[0].Name);
			Assert.Equal("Leia Organa", leftComparison.Friends[1].Name);
			Assert.Equal("C-3PO", leftComparison.Friends[2].Name);
			Assert.Equal("R2-D2", leftComparison.Friends[3].Name);

			var rightComparison = graphQLResponse.GetDataFieldAs<Person>("rightComparison");
			Assert.Equal("R2-D2", rightComparison.Name);
			Assert.Equal("NEWHOPE", rightComparison.AppearsIn[0]);
			Assert.Equal("EMPIRE", rightComparison.AppearsIn[1]);
			Assert.Equal("JEDI", rightComparison.AppearsIn[2]);
			Assert.Equal("Luke Skywalker", rightComparison.Friends[0].Name);
			Assert.Equal("Han Solo", rightComparison.Friends[1].Name);
			Assert.Equal("Leia Organa", rightComparison.Friends[2].Name);
		}

		[Fact]
		public void OperationNameResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.OperationNameResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);
			Assert.Equal("Luke Skywalker", data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void VariablesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.VariablesResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);
			Assert.Equal("Luke Skywalker", data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void DirectivesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.DirectivesResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
		}

		[Fact]
		public void MutationsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.MutationsResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal(5, data.createReview.stars.Value);
			Assert.Equal("This is a great movie!", data.createReview.commentary.Value);
		}

		[Fact]
		public void InlineFragmentsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.InlineFragmentsResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", data.hero.name.Value);
			Assert.Equal("Astromech", data.hero.primaryFunction.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Astromech", hero.PrimaryFunction);
		}

		[Fact]
		public void MetaFieldsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.MetaFieldsResponse;
			dynamic data = graphQLResponse.Data;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Human", data.search[0].__typename.Value);
			Assert.Equal("Han Solo", data.search[0].name.Value);
			Assert.Equal("Human", data.search[1].__typename.Value);
			Assert.Equal("Leia Organa", data.search[1].name.Value);
			Assert.Equal("Starship", data.search[2].__typename.Value);
			Assert.Equal("TIE Advanced x1", data.search[2].name.Value);
		}

	}

}
