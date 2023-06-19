﻿using MyMLApp;



var text = "";
while (text != "q")
{
    Console.WriteLine("Enter text to evaluate or Q to exit...");
    text = Console.ReadLine() ?? "q";
    // Add input data
    var sampleData = new SentimentModel.ModelInput()
    {
        Col0 = text
    };
    // Load model and predict output of sample data
    var result = SentimentModel.Predict(sampleData);

    // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
    var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
    Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
    Console.WriteLine($"{"-", -20}");

}