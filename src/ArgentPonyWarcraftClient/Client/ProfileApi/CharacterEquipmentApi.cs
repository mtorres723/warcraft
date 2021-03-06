﻿using System.Threading.Tasks;

namespace ArgentPonyWarcraftClient
{
    public partial class WarcraftClient
    {
        /// <inheritdoc />
        public async Task<RequestResult<CharacterEquipmentSummary>> GetCharacterEquipmentSummaryAsync(string realmSlug, string characterName, string @namespace)
        {
            return await GetCharacterEquipmentSummaryAsync(realmSlug, characterName, @namespace, _region, _locale);
        }

        /// <inheritdoc />
        public async Task<RequestResult<CharacterEquipmentSummary>> GetCharacterEquipmentSummaryAsync(string realmSlug, string characterName, string @namespace, Region region, Locale locale)
        {
            string host = GetHost(region);
            return await Get<CharacterEquipmentSummary>(region, $"{host}/profile/wow/character/{realmSlug}/{characterName?.ToLowerInvariant()}/equipment?namespace={@namespace}&locale={locale}");
        }
    }
}
