# DecisionTree and NaiveBayes Processes

This repository contains RapidMiner processes (`DT.rmp` and `NB.rmp`) to analyze eBay auction data and predict the competitiveness of listings using Decision Tree and Naive Bayes models.

## Overview

The processes are designed to:
1. Read and preprocess auction data from CSV files.
2. Train classification models (Decision Tree and Naive Bayes) to predict the "Competitiveness" of auctions.
3. Apply the trained models to new data for predictions.

## Input Data

The processes use the following CSV files:
- `eBayAuction.csv`: Training dataset with attributes like category, seller rating, duration, end day, open price, and competitiveness.
- `eBayPrediction.csv`: Dataset for making predictions.

### Attributes in the Dataset
- **Category**: Auction category (e.g., electronics, clothing).
- **Currency**: Currency of the auction (e.g., USD).
- **SellerRating**: Rating of the seller.
- **Duration**: Duration of the auction in days.
- **endDay**: Day of the week the auction ends.
- **OpenPrice**: Starting price of the auction.
- **Competitive**: Target variable indicating whether the auction is competitive.

## Workflow

### Common Steps (Both Processes)
1. **Read CSV**:
   - Load auction data from `eBayAuction.csv`.
2. **Filter Examples**:
   - Filter rows where the `Currency` is "US".
3. **Select Attributes**:
   - Exclude the `Currency` attribute from analysis.
4. **Replace Missing Values**:
   - Replace missing values in the `OpenPrice` attribute with the minimum value.
5. **Set Role**:
   - Set the `Competitive` attribute as the target (label) for training.

### Decision Tree Process
1. Trains a **Decision Tree** model with the following parameters:
   - **Criterion**: Gain ratio.
   - **Maximal Depth**: 10.
   - **Pruning**: Enabled with a confidence level of 0.1.
   - **Pre-Pruning**: Minimal gain of 0.03 and minimum leaf size of 5.
2. Applies the trained model to the `eBayPrediction.csv` dataset to generate predictions.

### Naive Bayes Process
1. Trains a **Naive Bayes** model.
2. Applies the trained model to the `eBayPrediction.csv` dataset to generate predictions.

## Output
Both processes produce:
- A trained model.
- Predictions on the `eBayPrediction.csv` dataset, including the predicted `Competitiveness` attribute.

## How to Use
1. Open RapidMiner Studio.
2. Load the `DecisionTree.rmp` or `NaiveBayes.rmp` file.
3. Ensure the CSV files (`eBayAuction.csv` and `eBayPrediction.csv`) are in the specified file paths.
4. Run the process.
5. Review the results in the output pane, including the model and predictions.

## Customization
- Update the `csv_file` parameter in the **Read CSV** operator to point to your dataset.
- Modify model parameters (e.g., maximal depth, confidence, etc.) to experiment with different configurations.

## Requirements
- RapidMiner Studio version 10.4.003 or higher.
- Datasets in CSV format matching the specified schema.

## Author
Dalton Outlaw  
Created using RapidMiner Studio for machine learning and data analysis.
