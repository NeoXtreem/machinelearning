// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using Microsoft.ML;

[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.TestFramework" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Tests" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Core.Tests" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Predictor.Tests" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Sweeper.Tests" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.InferenceTesting" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.OnnxTransformerTest" + PublicKey.TestValue)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.AutoML.Tests" + PublicKey.TestValue)]

[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.EntryPoints" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Maml" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.ResultProcessor" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.CpuMath" + PublicKey.Value)]

[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Data" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Api" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Ensemble" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.FastTree" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Mkl.Components" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.KMeansClustering" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.LightGbm" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.OnnxConverter" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.OnnxTransformer" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Parquet" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.PCA" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.PipelineInference" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Recommender" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.ImageAnalytics" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Scoring" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.StandardTrainers" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Sweeper" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.TensorFlow" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Vision" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.TimeSeries" + PublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Transforms" + PublicKey.Value)]

[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.AutoML" + PublicKey.Value)]

[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Internal.MetaLinearLearner" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "TreeVisualizer" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "TMSNlearnPrediction" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.CntkWrapper" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.DssmFeaturizer" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.DssmTrigram" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.EdgeML" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "ExperimentVisualization" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Internal.FastTree" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Garage" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.HelperCommands" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Internal.ImageAnalytics" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "ImageNetClientSample" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.InferNetWrapper" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.TlcTesting.Inference" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Internal.RecipeInference" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.LDSVM" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "LibSvmWrapper" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "maml" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "TLCTelemetry, PublicKey=0024000004800000940000000602000000240000525341310004000001000100edfd1aca74f2e8d6d7fd53d6f0bf77982ea38a5d2dc462f2f9f01f0734d87a8480279e02c42df82024ea146bf9721a86c50740b9809e4f379a848e1c5168bbfc2b3969aacec1822b3a29db0a23dce5502d764bc0d6ca68f5e4a53ad5212c427567545ec7027402b908460476bcc690a730d25532399e9ce5de32bfdc2211f7e0")]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Internal.Api" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "RunTests" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.PyTrainer" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "ParameterMixer" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.OcrTransform" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.RServerScoring.TextAnalytics" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.TextAnalytics" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "StratoLearner" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.SequencePrediction" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Internal.Opencv" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Sar" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.NeuralNetworks" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.PowerShellIntegration" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.RServerScoring.NeuralNetworks" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "TMSNStreams" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.TlcAzurePublish" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.VowpalWabbit" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.XGBoost" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.SLib" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "RunTestsMore" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.RServerScoring" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Sweeper" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.TlcCustomModule" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.SweeperHpc" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "Microsoft.ML.Runtime.Scope" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "NeuralNetworksTest" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "RunEndToEnd" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "RunTestsAzurePublish" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "SseTests" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "TLC" + InternalPublicKey.Value)]
[assembly: InternalsVisibleTo(assemblyName: "DotNetBridge" + InternalPublicKey.Value)]

[assembly: WantsToBeBestFriends]
