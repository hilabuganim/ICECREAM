using BigML;
using System;
using System.Threading.Tasks;
using DataSet = BigML.DataSet;

namespace icecream.Controllers
{
    /// <summary>
    /// This example creates a prediction using a model created with the data
    /// stored in a remote file.
    ///
    /// See complete API developers documentation at https://bigml.com/api
    /// </summary>
    public class CreatesPrediction
    {
        public static async void Main1()
        {
            // --- New BigML client using user name and API key ---
            var user = "hilabuganim";
            var apiKey = "475c79ac4b7f32ed1cb1661cd95e6af46e96f303";
            var client = new Client(user, apiKey);

            // --- create a source from the data in a remote file ---

            // setting the parameters to be used in source creation
            var parameters = new Source.Arguments();
            parameters.Add("name", "my new source");
            // uploading a remote file
            parameters.Add("remote", "https://static.bigml.com/csv/iris.csv");
            // if you need to upload a local file, change last line to
            // parameters.Add("file", "iris.csv");
            // Source object which will encapsulate the source information
            Source source = await client.CreateSource(parameters);
            // API calls are asynchronous, so you need to check that the source is finally
            // finished. To learn about the possible states for
            // BigML resources, please see http://bigml.com/api/status_codes
            while ((source = await client.Get<Source>(source))
                                         .StatusMessage
                                         .NotSuccessOrFail())
            {
                await Task.Delay(5000);
            }

            // --- create a dataset from the previous source ---
            // setting the parameters to be used in dataset creation
            var parameters1 = new DataSet.Arguments();
            parameters1.Add("name", "my new dataset");
            // using the source ID as argument
            parameters1.Add("source", source.Resource);
            // Dataset object which will encapsulate the dataset information
            DataSet dataset = await client.CreateDataset(parameters1);
            // checking the dataset status
            while ((dataset = await client.Get<DataSet>(dataset))
                                          .StatusMessage
                                          .NotSuccessOrFail())
            {
                await Task.Delay(5000);
            }

            // --- create a model from the previous dataset ---
            // setting the parameters to be used in model creation
            var parameters2 = new Model.Arguments();
            parameters2.Add("name", "my new model");
            // using the dataset ID as argument
            parameters2.Add("dataset", dataset.Resource);
            // Model object which will encapsulate the model information
            Model model = await client.CreateModel(parameters2);
            // checking the model status
            while ((model = await client.Get<Model>(model))
                                        .StatusMessage
                                        .NotSuccessOrFail())
            {
                await Task.Delay(5000);
            }

            // --- create a prediction using the model ---
            // setting the parameters to be used in prediction creation
            var parameters3 = new Prediction.Arguments();
            // using the model ID as argument
            parameters3.Add("model", model.Resource);
            // set INPUT DATA for prediction: {'petal length': 5, 'sepal width': 2.5}
            parameters3.InputData.Add("petal length", 5);
            parameters3.InputData.Add("sepal width", 2.5);

            // SET MISSING STRATEGY and NAME
            parameters3.Add("missing_strategy", 1); //Proportional
            parameters3.Add("name", "prediction w/ PROPORTIONAL");
            // Prediction object which will encapsulate the prediction information
            Prediction prediction = await client.CreatePrediction(parameters3);
            // checking the prediction status
            while ((prediction = await client.Get<Prediction>(prediction))
                                             .StatusMessage
                                             .NotSuccessOrFail())
            {
                await Task.Delay(2000);
            }
            Console.WriteLine("------------------------------\nMissing strategy PROPORTIONAL");
            Console.WriteLine("Prediction: " + prediction.GetPredictionOutcome<string>());
            Console.WriteLine("Confidence: " + prediction.Confidence);


            // Test same input_data, but with missing_stategy = 0 (default value)
            // UPDATE MISSING STRATEGY and NAME
            parameters3.Update("missing_strategy", 0); //Last prediction
            parameters3.Update("name", "prediction w/ LAST PREDICTION");
            prediction = await client.CreatePrediction(parameters3);
            while ((prediction = await client.Get<Prediction>(prediction))
                                             .StatusMessage
                                             .NotSuccessOrFail())
            {
                await Task.Delay(2000);
            }

            Console.WriteLine("------------------------------\nMissing strat. LAST PREDICTION");
            Console.WriteLine("Prediction: " + prediction.GetPredictionOutcome<string>());
            Console.WriteLine("Confidence: " + prediction.Confidence);
            Console.WriteLine("------------------------------");
        }
    }
}