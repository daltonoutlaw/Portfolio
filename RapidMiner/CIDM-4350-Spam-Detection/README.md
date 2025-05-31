# Text Classification Process  

## Overview  
This project demonstrates a text classification pipeline using XML-based workflow configuration in a data mining tool (e.g., RapidMiner). The workflow processes text data for spam classification, utilizing the **Challenge-Action-Result** framework to implement and evaluate a **Naive Bayes** model on a dataset.  

The workflow includes key stages such as reading a CSV file, preprocessing text data, generating n-grams, and performing model validation to classify messages into categories like spam or not spam.  

---

## Workflow Components  

### 1. **Data Import (Read CSV)**  
- Reads the **SMSSpamCollection.csv** file containing text messages.  
- Key configuration parameters:  
  - **Column separator**: Tab (`\t`)  
  - **Starting row**: 1  
  - **First row as names**: Enabled  

---

### 2. **Text Processing**  
- **Tokenization**: Splits messages into tokens using non-letters as delimiters.  
- **N-grams generation**: Creates bigrams (n-grams of size 2) from the tokenized text.  
- **Term occurrences vector**: Converts text data into a structured format for analysis.  

---

### 3. **Model Training and Validation**  
- **Split Validation**:  
  - Splits data into **training** (70%) and **test** (30%) sets using stratified sampling.  
  - A Naive Bayes model is trained on the training set with Laplace correction enabled.  

- **Model Application**:  
  - Applies the trained model to the test set for classification.  
  - Outputs classification results and associated performance metrics.  

---

### 4. **Performance Evaluation**  
- Key metrics used to evaluate the Naive Bayes model:  
  - **Accuracy**  
  - **Confusion Matrix**  
  - Additional metrics can be enabled for further analysis.  

---

## Key Features  
- Uses **Challenge-Action-Result** methodology for clear workflow organization.  
- Enables text classification with preprocessing steps like tokenization and n-gram generation.  
- Leverages Naive Bayes as a simple yet effective classifier for text data.  
- Implements split validation for robust model evaluation.  

---

## Files and Directories  
- **SMSSpamCollection.csv**: Input dataset containing text messages.  
- **Workflow XML File**: Configuration file describing the entire pipeline.  

---

## How to Use  
1. Ensure the input file (`SMSSpamCollection.csv`) is in the specified directory path.  
2. Load the XML file into a compatible data mining tool (e.g., RapidMiner).  
3. Execute the process to preprocess the text data, train the Naive Bayes model, and evaluate performance.  
4. Review outputs, including the performance metrics and classification results.  

---

## Future Enhancements  
- Add advanced preprocessing steps, such as stopword removal and stemming.  
- Experiment with other machine learning algorithms for improved performance.  
- Expand performance evaluation metrics for deeper insights.  
