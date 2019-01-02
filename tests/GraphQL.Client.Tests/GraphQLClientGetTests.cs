using GraphQL.Common.Request;
using GraphQL.Common.Tests.Model;
using Xunit;

namespace GraphQL.Client.Tests {

	public class GraphQLClientGetTests : BaseGraphQLClientTest {

		[Fact]
		public async void QueryGetAsyncFact() {
			var graphQLRequest = new GraphQLRequest {
				Query = @"
				{
					person(personID: ""1"") {
						name
					}
				}"
			};
			var response = await this.GraphQLClient.GetAsync(graphQLRequest).ConfigureAwait(false);
			dynamic data = response.Data;

			Assert.Equal("Luke Skywalker", data.person.name.Value);
			Assert.Equal("Luke Skywalker", response.GetDataFieldAs<Person>("person").Name);
		}

		[Fact]
		public async void OperationNameGetAsyncFact() {
			var graphQLRequest = new GraphQLRequest {
				Query = @"
				query Person{
					person(personID: ""1"") {
						name
					}
				}

				query Planet {
					planet(planetID: ""1"") {
						name
					}
				}",
				OperationName = "Person"
			};
			var response = await this.GraphQLClient.GetAsync(graphQLRequest).ConfigureAwait(false);
			dynamic data = response.Data;

			Assert.Equal("Luke Skywalker", data.person.name.Value);
			Assert.Equal("Luke Skywalker", response.GetDataFieldAs<Person>("person").Name);
		}

		[Fact]
		public async void VariablesGetAsyncFact() {
			var graphQLRequest = new GraphQLRequest {
				Query = @"
				query Person($personId: ID!){
					person(personID: $personId) {
						name
					}
				}",
				Variables = new {
					personId = "1"
				}
			};
			var response = await this.GraphQLClient.GetAsync(graphQLRequest).ConfigureAwait(false);
			dynamic data = response.Data;

			Assert.Equal("Luke Skywalker", data.person.name.Value);
			Assert.Equal("Luke Skywalker", response.GetDataFieldAs<Person>("person").Name);
		}

		[Fact]
		public async void OperationNameVariableGetAsyncFact() {
			var graphQLRequest = new GraphQLRequest {
				Query = @"
				query Person($personId: ID!){
					person(personID: $personId) {
						name
					}
				}

				query Planet {
					planet(planetID: ""1"") {
						name
					}
				}",
				OperationName = "Person",
				Variables = new {
					personId = "1"
				}
			};
			var response = await this.GraphQLClient.GetAsync(graphQLRequest).ConfigureAwait(false);
			dynamic data = response.Data;

			Assert.Equal("Luke Skywalker", data.person.name.Value);
			Assert.Equal("Luke Skywalker", response.GetDataFieldAs<Person>("person").Name);
		}

	}

}
