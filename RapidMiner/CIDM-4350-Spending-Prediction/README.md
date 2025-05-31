# RapidMiner Process: Naive Bayes Classification for Predicting "Education Spending"

## Overview
This RapidMiner process utilizes a Naive Bayes algorithm to classify and predict "education spending" based on labeled training data and test data. The process includes reading CSV files, setting roles for attributes, training a Naive Bayes model, and applying the trained model to predict outcomes on new data.

## Key Steps in the Process

1. **Read Training Data**
   - The process begins by importing a CSV file (`vote-train.csv`) containing training data.
   - Relevant parameters for parsing the CSV include:
     - Column separator: `,`
     - Use header row: `true`
     - Data encoding: `UTF-8`
     - Attributes are predefined for the dataset.

2. **Set Role for Training Data**
   - The "education-spending" attribute is set as the **label**, which the Naive Bayes model will learn to predict.

3. **Train Naive Bayes Model**
   - A Naive Bayes model is trained using the labeled training data.
   - Laplace correction is enabled to handle unseen attribute values.

4. **Read Test Data**
   - A second CSV file (`vote-predict-vote.csv`) is read to provide the test dataset for predictions.
   - Similar parsing configurations are applied as with the training data.

5. **Set Role for Test Data**
   - The "education-spending" attribute in the test data is set as **prediction**, allowing the model to output predicted values for this attribute.

6. **Apply Model**
   - The trained Naive Bayes model is applied to the test dataset.
   - Outputs include:
     - Predicted labels for the test data.
     - The trained model for further use or validation.

## Files Used
- **Training Data**: `vote-train.csv`
- **Test Data**: `vote-predict-vote.csv`

## Outputs
1. **Predicted Results**:
   - The predicted "education-spending" values for the test data.
2. **Model Output**:
   - The trained Naive Bayes model for further analysis or reusability.

## Configuration Details
- **Random Seed**: `2001` (to ensure reproducibility)
- **CSV Encoding**: `UTF-8`
- **Locale**: `English (United States)`

## Prerequisites
- Install RapidMiner Studio (Version 10.4.003 or compatible).
- Ensure the CSV files are accessible in the specified directory paths.

## How to Use
1. Place the training (`vote-train.csv`) and test (`vote-predict-vote.csv`) CSV files in the appropriate directory.
2. Open the RapidMiner process in RapidMiner Studio.
3. Execute the process to train the model and generate predictions for the test data.

## Notes
- The process uses the Naive Bayes algorithm, which is effective for categorical data and assumes feature independence.
- Ensure the training and test datasets have matching attribute configurations for seamless integration.
