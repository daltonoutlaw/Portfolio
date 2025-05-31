# Overview of Process Workflow

This workflow, created in a data analytics and machine learning platform (e.g., RapidMiner), reads and processes data for clustering and statistical analysis using a step-by-step pipeline. It includes operations for reading a dataset, preprocessing it, performing clustering, and analyzing group differences using ANOVA.

---

## Workflow Components

### 1. **Read CSV**
   - **Function**: Reads the dataset from a CSV file.
   - **Parameters**:
     - File Path: `/Users/daltonoutlaw/Downloads/CarsCSV(2).csv`
     - Column Separator: `,`
     - Header Row: Enabled
     - Encoding: `UTF-8`
   - **Dataset Attributes**:
     - `mpg` (real)
     - `cylinders` (integer)
     - `cubicinches` (integer)
     - `hp` (integer)
     - `weightlbs` (integer)
     - `time-to-60` (integer)
     - `year` (integer)
     - `brand` (polynomial)

---

### 2. **Work on Subset**
   - **Function**: Selects specific attributes for further processing.
   - **Attributes Selected**: `cubicinches`, `weightlbs`, `cylinders`

---

### 3. **Preprocessing and Clustering**
   - **Normalize**:
     - Scales numeric attributes to a range of `[0, 1]`.
   - **Agglomerative Clustering**:
     - Groups data into clusters using average link and Euclidean distance.
   - **Flatten Clustering**:
     - Reduces clustering results to 3 clusters.
     - Adds the cluster as a label.

---

### 4. **Statistical Analysis**
   - **Grouped ANOVA**:
     - Analyzes variance in the `mpg` attribute across clusters.
     - **Group By**: Cluster label.
     - **Significance Level**: `0.05`

---

## Workflow Flow

1. **Data Input**:
   - Reads data from the CSV file and processes it with specified configurations.

2. **Attribute Subset Selection**:
   - Filters the data to include only relevant numeric attributes.

3. **Clustering Pipeline**:
   - Normalizes numeric attributes.
   - Performs clustering to group data into clusters.
   - Labels data with cluster assignments.

4. **ANOVA Analysis**:
   - Compares the variance of `mpg` across identified clusters to determine statistically significant differences.

---

## Results

- **Clustered Data**: The dataset with added cluster labels.
- **ANOVA Results**: Significance levels indicating differences in `mpg` between clusters.

---

## How to Use

1. **Input Data**:
   - Replace the CSV file path with your own dataset.
2. **Modify Parameters**:
   - Adjust attribute selections, clustering parameters, or statistical tests as needed.
3. **Run Process**:
   - Execute the workflow to process data, perform clustering, and analyze results.
4. **Interpret Results**:
   - Use clustering and ANOVA outputs to derive insights from the data.

