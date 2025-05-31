# Process Overview: CSV Data Clustering with K-Means

This XML process file is a RapidMiner workflow designed to perform K-Means clustering on the famous Iris dataset. The workflow reads data from a CSV file, selects relevant attributes for clustering, and applies the K-Means algorithm. Below is an overview of the key components and functionality:

---

## Workflow Steps

1. **Read CSV Data**
   - **Operator**: `Read CSV`
   - **Description**: Reads the dataset from a CSV file located at `/Users/daltonoutlaw/Downloads/iris_full.csv`.
   - **Key Parameters**:
     - Column separator: `,`
     - Encoding: `UTF-8`
     - Header row: `true`
     - Attributes include:
       - `Species_No` (integer)
       - `Petal_width` (real)
       - `Petal_length` (real)
       - `Sepal_width` (real)
       - `Sepal_length` (real)
       - `Species_name` (polynominal)

2. **Work on Subset**
   - **Operator**: `Work on Subset`
   - **Description**: Filters and processes a subset of attributes for clustering.
   - **Selected Attributes**:
     - `Petal_length`
     - `Petal_width`
     - `Sepal_length`
     - `Sepal_width`

3. **K-Means Clustering**
   - **Operator**: `Clustering (K-Means)`
   - **Description**: Groups the dataset into 3 clusters using the K-Means algorithm.
   - **Key Parameters**:
     - Number of clusters (`k`): 3
     - Maximum iterations: 10
     - Distance measure: Euclidean
     - Add cluster attribute: `true`
     - Random seed: `1992` (ensures reproducibility)

---

## Key Features

- **Data Preparation**:
  - Cleans and integrates the Iris dataset.
  - Selects relevant attributes to focus on key features for clustering.

- **Clustering Analysis**:
  - Applies the K-Means algorithm to group data into clusters.
  - Outputs clustered data and the cluster model for further analysis.

---

## File Information

- **Input File**: `iris_full.csv`  
  Ensure the CSV file is correctly formatted with the appropriate headers and data types as defined in the workflow.

- **Output**: 
  - Clustered dataset with a new attribute identifying the assigned cluster.
  - Cluster model for evaluation and visualization.

---

## How to Run

1. Open this process file in RapidMiner (version 10.4.003 or compatible).
2. Verify that the input CSV file path is correct.
3. Run the workflow to generate clustered results.
4. Review outputs to analyze the clusters and their characteristics.

---

## Customization

- Modify the `k` value in the K-Means operator to change the number of clusters.
- Update the `csv_file` path parameter to point to your dataset.
- Add or remove attributes in the "Work on Subset" operator to customize clustering inputs.

---
