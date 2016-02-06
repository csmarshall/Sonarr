﻿using NLog;
using NzbDrone.Common.Disk;
using NzbDrone.Core.Extras.Files;
using NzbDrone.Core.Tv;

namespace NzbDrone.Core.Extras.Metadata.Files
{
    public interface IMetadataFileService : IExtraFileService<MetadataFile>
    {
    }

    public class MetadataFileService : ExtraFileService<MetadataFile>, IMetadataFileService
    {
        public MetadataFileService(IExtraFileRepository<MetadataFile> repository, ISeriesService seriesService, IDiskProvider diskProvider, Logger logger)
            : base(repository, seriesService, diskProvider, logger)
        {
        }
    }
}
