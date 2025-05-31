# Decision Tree Model with Challenge-Action-Result Framework

## Overview

This project is a process workflow designed to implement a Decision Tree algorithm for classifying Iris plant species. It utilizes RapidMiner's XML-based process format and demonstrates an end-to-end pipeline for training, applying, and evaluating a predictive model using the Challenge-Action-Result (CAR) framework.

### Key Components
1. **Training Data Import**  
   - Reads and preprocesses a CSV file containing training data (`iris_train.csv`).
   - Attributes include petal/sepal dimensions and species.

2. **Feature Selection**  
   - Filters the dataset to include only relevant attributes:
     - `Petal_length`, `Petal_width`, `Sepal_length`, `Sepal_width`, and `Species_name`.

3. **Set Role for Labeling**  
   - Assigns `Species_name` as the label attribute for model training.

4. **Decision Tree Model Training**  
   - Trains a decision tree using the `gain_ratio` criterion with pre-pruning and post-pruning applied.
   - Configured with parameters such as maximal depth (10), minimal gain (0.01), and minimal leaf size (2).

5. **Prediction Data Import**  
   - Reads a second CSV file (`iris_predict.csv`) containing new data for prediction.

6. **Set Role for Prediction**  
   - Assigns `Species_name` as the target for prediction in the test dataset.

7. **Model Application**  
   - Applies the trained Decision Tree model to the prediction dataset.
   - Produces labeled results and exports the model for further use.

8. **Connections**  
   - Operators are connected to form a streamlined workflow, ensuring efficient data flow from input to output.

---

## File Inputs
- `iris_train.csv`: Training data containing labeled examples.
- `iris_predict.csv`: Prediction data with unlabeled examples.

---

## Configuration Highlights
- **Decision Tree Parameters**:
  - Criterion: `gain_ratio`
  - Maximal Depth: `10`
  - Confidence (pruning): `0.1`
  - Minimal Gain: `0.01`
  - Minimal Leaf Size: `2`
- **Data Preprocessing**:
  - CSV files are processed with a header row, comma-separated values, and UTF-8 encoding.

---

## Outputs
- **Labeled Dataset**: The prediction results, where each record is classified into one of the species.
- **Trained Model**: A reusable Decision Tree model for future applications.

---

## Steps to Execute
1. Place `iris_train.csv` and `iris_predict.csv` in the specified paths.
2. Load the process into RapidMiner.
3. Execute the workflow.
4. Review the labeled data and exported model in the results.

---

## Purpose
This workflow provides an efficient way to classify plant species based on their features while showcasing the application of the Challenge-Action-Result methodology:
- **Challenge**: Build an accurate classification model for Iris species.
- **Action**: Preprocess data, select features, train a Decision Tree, and apply the model.
- **Result**: Generate actionable predictions and insights for species classification.
